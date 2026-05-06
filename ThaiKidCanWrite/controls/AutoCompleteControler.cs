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
using DevExpress.XtraRichEdit;
using DevExpress.XtraEditors;
namespace LDWordProcessor.form
{
    public partial class AutoCompleteControler : UserControl
    {    
        private Logger logger = LogManager.GetCurrentClassLogger();
        private AutoCompleteLib ac = NectecAPI.Instance.AutoComplete;
        private PredictLib pd = NectecAPI.Instance.Predict;
        private string searchWord;
        private WordSuggestType wsType = WordSuggestType.None;
        private ReaderComponent reader;
        private int numOfComplete = 7;
        private int numOfPredict = 7;
        private const int numOfCountPerPage = 7;
        private int numOfAllPage = 1;
        private int numOfPage = 1;
        private TextBox tbSelect;
        private RichEditControl rtSelect;
        private RichEditHelper iRichHelper;
        private TextReader textReader;
        private List<string> suggestResults = new List<string>();
        public event SelectWordSuggestEventHandler SelectWordSuggestEvent;
        private LDDictionary dict = new LDDictionary();

        public AutoCompleteControler()
        {
            InitializeComponent();
            iRichHelper = new RichEditHelper(new RichEditControl());
            textReader = new TextReader(iRichHelper);

            btnPredictBack.Enabled = false;
            btnPredictNext.Enabled = false;

            NumOfComplete = 17;
            NumOfPredict = 17;
        }
        public int NumOfComplete
        {
            get { return numOfComplete; }
            set { numOfComplete = value; }
        }
        public int NumOfPredict
        {
            get { return numOfPredict; }
            set { numOfPredict = value; }
        }
        public int ListCount(string word, int statusWord)
        {
            logger.Debug("Suggest For: {0}", word);
            wsType = WordSuggestType.None;
            searchWord = word;
            tbWordPredict.Text = word;
            List<string> acl = ac.AutoComplete(word, 5);
            LDUtils.printList(acl, "Auto Complete");
            if (acl.IndexOf(word) == -1 || statusWord == 1)
            {
                return acl.Count;
            }
            else
            {
                List<string> pl = pd.Predict(word, 5);
                return pl.Count;
            }
        }
        public void ListSuggest(string word)
        {
            logger.Debug("Suggest For: {0}", word);
            wsType = WordSuggestType.None;
            searchWord = word;
            List<string> acl = ac.AutoComplete(word, NumOfComplete);
            LDUtils.printList(acl, "Auto Complete");
            if (acl.IndexOf(word) == -1)
            {
                if (acl.IndexOf(word) == 0 && acl.Count > 0)
                {
                    acl.RemoveAt(0);
                }
                suggestResults = acl;
                wsType = WordSuggestType.AutoComplete;
                DisplaySuggestion();
            }
            else
            {
                List<string> pl = pd.Predict(word, NumOfPredict);
                suggestResults = pl;
                wsType = WordSuggestType.Prediction;
                DisplaySuggestion();
                LDUtils.printList(pl, "Prediction");
            }
        }
        public void ListSuggest(string word, int statusWord)
        {
            logger.Debug("Suggest For: {0}", word);
            wsType = WordSuggestType.None;
            searchWord = word;
            List<string> acl = ac.AutoComplete(word, NumOfComplete);
            LDUtils.printList(acl, "Auto Complete");
            //Console.WriteLine("word-->" + word);
            // Console.WriteLine("acl.IndexOf-->" + acl.IndexOf(word));
            
            if (acl.IndexOf(word) == -1 || statusWord == 1)
            {
                if (acl.IndexOf(word) == 0 && acl.Count > 0)
                {
                    acl.RemoveAt(0);
                }

                suggestResults = acl;
                wsType = WordSuggestType.AutoComplete;
                DisplaySuggestion();
            }
            else
            {
                List<string> pl = pd.Predict(word, NumOfPredict);
                suggestResults = pl;
                wsType = WordSuggestType.Prediction;
                LDUtils.printList(pl, "Prediction");
                DisplaySuggestion();
            }
        }
        public void Clear()
        {
            if (suggestResults != null)
            {
                suggestResults.Clear();
            }
            tbWordPredict.Text = "";
            DisplaySuggestion();

        }
        public RichEditControl RtSelect
        {
            get { return rtSelect; }
            set { rtSelect = value; }
        }
        public TextBox TbSelect
        {
            get { return tbSelect; }
            set { tbSelect = value; }
        }
        public void DisplaySuggestion()
        {
            if (suggestResults.Count < 1)
            {
                if (suggestResults != null)
                {
                    suggestResults.Clear();
                }
                btnPredictOutput1.Text = "";
                btnPredictOutput2.Text = "";
                btnPredictOutput3.Text = "";
                btnPredictOutput4.Text = "";
                btnPredictOutput5.Text = "";
                btnPredictOutput6.Text = "";
                btnPredictOutput7.Text = "";
                btnPredictOutput1.Enabled = true;
                btnPredictOutput2.Enabled = true;
                btnPredictOutput3.Enabled = true;
                btnPredictOutput4.Enabled = true;
                btnPredictOutput5.Enabled = true;
                btnPredictOutput6.Enabled = true;
                btnPredictOutput7.Enabled = true;
                return;
            }

            if (suggestResults.Count > 0)
            {
                numOfPage = 1;
                numOfAllPage = suggestResults.Count / numOfCountPerPage;
                if (numOfAllPage > 1)
                {
                    btnPredictNext.Enabled = true;
                }
                else
                {
                    btnPredictBack.Enabled = false;
                    btnPredictNext.Enabled = false;
                }
                setWordPage(1);
            }
        }
        private void setWordPage(int page)
        {
            int start = numOfCountPerPage * (page - 1);
            int end = numOfCountPerPage * page - 1;
            int btnIndex = 0;
            for (int k = start; k <= end; k++)
            {
                if (k >= suggestResults.Count)
                {
                    switch (btnIndex)
                    {
                        case 0: btnPredictOutput1.Text = ""; btnPredictOutput1.Enabled = false; break;
                        case 1: btnPredictOutput2.Text = ""; btnPredictOutput2.Enabled = false; break;
                        case 2: btnPredictOutput3.Text = ""; btnPredictOutput3.Enabled = false; break;
                        case 3: btnPredictOutput4.Text = ""; btnPredictOutput4.Enabled = false; break;
                        case 4: btnPredictOutput5.Text = ""; btnPredictOutput5.Enabled = false; break;
                        case 5: btnPredictOutput6.Text = ""; btnPredictOutput6.Enabled = false; break;
                        case 6: btnPredictOutput7.Text = ""; btnPredictOutput7.Enabled = false; break;
                        default: break;
                    }
                    btnIndex++;
                    continue;
                }
                switch (btnIndex)
                {
                    case 0: btnPredictOutput1.Text = suggestResults[k]; btnPredictOutput1.Enabled = true; break;
                    case 1: btnPredictOutput2.Text = suggestResults[k]; btnPredictOutput2.Enabled = true; break;
                    case 2: btnPredictOutput3.Text = suggestResults[k]; btnPredictOutput3.Enabled = true; break;
                    case 3: btnPredictOutput4.Text = suggestResults[k]; btnPredictOutput4.Enabled = true; break;
                    case 4: btnPredictOutput5.Text = suggestResults[k]; btnPredictOutput5.Enabled = true; break;
                    case 5: btnPredictOutput6.Text = suggestResults[k]; btnPredictOutput6.Enabled = true; break;
                    case 6: btnPredictOutput7.Text = suggestResults[k]; btnPredictOutput7.Enabled = true; break;
                    default: break;
                }
                btnIndex++;
            }
        }      
        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            btnPredictNext.Enabled = true;
            if (numOfPage > 1)
            {
                btnPredictBack.Enabled = true;
                numOfPage--;
                if (numOfPage == 1)
                {
                    btnPredictBack.Enabled = false;
                }
                setWordPage(numOfPage);
            }
        }
        private void btnSearchNext_Click(object sender, EventArgs e)
        {
            if (numOfPage <= numOfAllPage)
            {
                btnPredictBack.Enabled = true;;
                numOfPage++;
                if (numOfPage < numOfAllPage)
                {
                    btnPredictNext.Enabled = true;
                }
                else
                {
                    btnPredictNext.Enabled = false;
                }
                setWordPage(numOfPage);
            }
        }

        private void btnSearchOutput_DoubleClick(object sender, MouseEventArgs e)
        {
            if (SelectWordSuggestEvent != null)
            {
                string selected = (string)((SimpleButton)sender).Text;
                if (selected.Equals(""))
                    return;
                tbWordPredict.Text = selected;
                SelectWordSuggestEvent(searchWord, selected, wsType);
                logger.Debug(String.Format("[searchWord, selected, wsType] = {0},{1},{2}", searchWord, selected, wsType));
                switch (wsType)
                {
                    case WordSuggestType.AutoComplete:
                        ac.Update(searchWord, selected);
                        break;
                    case WordSuggestType.Prediction:
                        pd.Update(searchWord, selected);
                        break;
                }
            }
        }
        private void btnSearchOutput_Click(object sender, MouseEventArgs e)
        {
            try { textReader.Stop(); }
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

        private void tbWordPredict_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPredictOutput1_Click(object sender, EventArgs e)
        {

        }
    }
}


