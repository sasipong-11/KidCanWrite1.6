using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LDWordProcessor.nectec;
using WordProcLD;
using NLog;
using LDWordProcessor.db;
using DevExpress.XtraRichEdit;
using DevExpress.XtraEditors;
using LDWordProcessor.Class;

namespace LDWordProcessor
{
    public partial class WordSearchControler : UserControl
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private const int numOfSuggest = 70;
        private const int numOfCountPerPage = 7;
        private int numOfAllPage = 1;
        private int numOfPage = 1;
        private TextBox tbInput;
        private Page trackPage = Page.None;
        private FixWord _fixword;
        private SpellWordSuggestEntry[]  WordSuggest;
        private RichEditHelper iRichHelper;
        private TextReader textReader;
        private LDDictionary dict = new LDDictionary();
        public event SelectWordSuggestEventHandler SelectWordSuggestEvent;
        private WordSuggestType wsType = WordSuggestType.None;
        public WordSearchControler()
        {
            InitializeComponent();
            btnSearchBack.Enabled = false;
            btnSearchNext.Enabled = false;
            iRichHelper = new RichEditHelper(new RichEditControl());
            textReader = new TextReader(iRichHelper);
        }
        public TextBox TbInput
        {
            get { return tbInput; }
            set { tbInput = value; }
        }

        public Page TrackPage
        {
            get { return trackPage; }
            set { trackPage = value; }
        }

        private void setWordPage(int page)
        {
            int start = numOfCountPerPage * (page - 1);
            int end = numOfCountPerPage * page - 1;
            string type = WordSuggest.GetType().ToString();
            int btnIndex = 0;
            for (int k = start; k <= end; k++)
            {
                if (k >= WordSuggest.Length)
                {
                    switch (btnIndex)
                    {
                        case 0: btnSearchOutput1.Text = ""; btnSearchOutput1.Enabled = false; break;
                        case 1: btnSearchOutput2.Text = ""; btnSearchOutput2.Enabled = false; break;
                        case 2: btnSearchOutput3.Text = ""; btnSearchOutput3.Enabled = false; break;
                        case 3: btnSearchOutput4.Text = ""; btnSearchOutput4.Enabled = false; break;
                        case 4: btnSearchOutput5.Text = ""; btnSearchOutput5.Enabled = false; break;
                        case 5: btnSearchOutput6.Text = ""; btnSearchOutput6.Enabled = false; break;
                        case 6: btnSearchOutput7.Text = ""; btnSearchOutput7.Enabled = false; break;
                        default: break;
                    }
                    btnIndex++;
                    continue;
                }
                switch (btnIndex)
                {
                    case 0: btnSearchOutput1.Text = WordSuggest[k].Text; btnSearchOutput1.Enabled = true; break;
                    case 1: btnSearchOutput2.Text = WordSuggest[k].Text; btnSearchOutput2.Enabled = true; break;
                    case 2: btnSearchOutput3.Text = WordSuggest[k].Text; btnSearchOutput3.Enabled = true; break;
                    case 3: btnSearchOutput4.Text = WordSuggest[k].Text; btnSearchOutput4.Enabled = true; break;
                    case 4: btnSearchOutput5.Text = WordSuggest[k].Text; btnSearchOutput5.Enabled = true; break;
                    case 5: btnSearchOutput6.Text = WordSuggest[k].Text; btnSearchOutput6.Enabled = true; break;
                    case 6: btnSearchOutput7.Text = WordSuggest[k].Text; btnSearchOutput7.Enabled = true; break;
                    default: break;
                }
                btnIndex++;
            }
        }
        private void tbWordSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string word = ((TextBox)sender).Text;
                // Fix คำเฉพาะรายการตาม class นี้
                _fixword = new FixWord();
                word = _fixword.CheckWord(word);

                WordSuggest = LDSuggestWord.GetSuggestWords(word, numOfSuggest);
                numOfPage = 1;
                if (WordSuggest.Length > 0)
                {
                    numOfAllPage = WordSuggest.Length / numOfCountPerPage;
                    if (numOfAllPage > 1)
                    {
                        btnSearchNext.Enabled = true;
                    }
                    else
                    {
                        btnSearchBack.Enabled = false;
                        btnSearchNext.Enabled = false;
                    }
                    setWordPage(1);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                clearBtnSearchOutput();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            btnSearchNext.Enabled = true;
            if (numOfPage > 1)
            {
                btnSearchBack.Enabled = true;
                numOfPage--;
                if (numOfPage == 1)
                {
                    btnSearchBack.Enabled = false;
                }
                setWordPage(numOfPage);
            }
        }
        private void btnSearchNext_Click(object sender, EventArgs e)
        {
            if (numOfPage <= numOfAllPage)
            {
                btnSearchBack.Enabled = true; ;
                numOfPage++;
                if (numOfPage < numOfAllPage)
                {
                    btnSearchNext.Enabled = true;
                }
                else
                {
                    btnSearchNext.Enabled = false;
                }
                setWordPage(numOfPage);
            }
        }
        private void btnSearchOutput_DoubleClick(object sender, MouseEventArgs e)
        {
           if (trackPage == Page.Mindmap) { 
                if (tbInput != null && !((SimpleButton)sender).Text.Equals(""))
                {
                  tbInput.Text += ((SimpleButton)sender).Text;
                   //tbInput.Text = "ทดสอบ";
                    //tbInput = null;
                }
            }
            else if(trackPage == Page.Editword)
            {
                if (SelectWordSuggestEvent != null)
                    SelectWordSuggestEvent("", ((SimpleButton)sender).Text.ToString(), wsType);
            }
            clearBtnSearchOutput();
        }

        private void btnSearchOutput_Click(object sender, MouseEventArgs e)
        {
            try{
                textReader.Stop();
            }
            catch { }
           
            SimpleButton btn = (SimpleButton)sender;
            if (((string)btn.Text).Length <= 1) return;
            textReader.ReadAllTextNoSelect((string)btn.Text);
        }

        //การอ่านออกเสียงความหมายคำศัพท์
        
        private void btnSearchOutput_MouseHover(object sender, EventArgs e)
        {
           SimpleButton btn = (SimpleButton)sender;
            string text_meaning = dict.Lookup(btn.Text);
            string text_read = text_meaning
                .Replace("[N]", "คำนาม")
                .Replace("[V]", "คำกริยา")
                .Replace("[CLAS]", "ลักษณะนาม")
                .Replace("[PRON]", "คำสรรพนาม")
                .Replace("[ADJ]", "คำคุณศัพท์")
                .Replace("[ADV]", "คำวิเศษณ์")
                .Replace("[PREP]", "คำบุพบท")
                .Replace("[CONJ]", "คำสันธาน")
                .Replace("[INT]", "คำอุทาน")
                .Replace(":", " หมายถึง ");


            //this.readButton(text_read);
  
            if (((string)btn.Text).Length <= 1) return;
            toolTipController1.Active = false;
            toolTipController1.SetToolTip(btn, null);
            toolTipController1.ShowHint(dict.Lookup(btn.Text));
            toolTipController1.Active = true;
            
        }

        nectec.VajaTTS ttsButton = new nectec.VajaTTS();
        private void readButton(String buttonInfo)
        {
            byte[] utf8Bytes;
            utf8Bytes = Encoding.UTF8.GetBytes(buttonInfo);
            byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);
            ttsButton.Text = Encoding.Unicode.GetString(unicodeBytes);
            ttsButton.Volume = 100;
            ttsButton.PlayButton();
        }
        
        //

        private void clearBtnSearchOutput()
        {
            try
            {
                btnSearchOutput1.Text = "";
                btnSearchOutput2.Text = "";
                btnSearchOutput3.Text = "";
                btnSearchOutput4.Text = "";
                btnSearchOutput5.Text = "";
                btnSearchOutput6.Text = "";
                btnSearchOutput7.Text = "";
                btnSearchOutput1.Enabled = false;
                btnSearchOutput2.Enabled = false;
                btnSearchOutput3.Enabled = false;
                btnSearchOutput4.Enabled = false;
                btnSearchOutput5.Enabled = false;
                btnSearchOutput6.Enabled = false;
                btnSearchOutput7.Enabled = false;
                btnSearchBack.Enabled = false;
                btnSearchNext.Enabled = false;
                tbWordSearch.Clear();
                numOfPage = 1;
            }
            catch { MessageBox.Show("ClearBut"); }
           
        }

        private void btnSearchOutput1_Click(object sender, EventArgs e)
        {

        }
    }
}
