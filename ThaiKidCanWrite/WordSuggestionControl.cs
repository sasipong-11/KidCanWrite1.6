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

namespace LDWordProcessor
{

    public partial class WordSuggestionControl : UserControl
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private AutoCompleteLib ac = NectecAPI.Instance.AutoComplete;
        private SpellingLib spl = NectecAPI.Instance.Spelling;
        private PredictLib pd = NectecAPI.Instance.Predict;
        public event SelectWordSuggestEventHandler SelectWordSuggestEvent;
        private string searchWord;
        private WordSuggestType wsType = WordSuggestType.None;
        private ReaderComponent reader;
        private int numOfComplete = 7;
        private int numOfPredict = 7;
        private string[] suggestWord;
        private string[] status;
        public ReaderComponent Reader
        {
            get { return reader; }
            set { reader = value; }
        }

        public WordSuggestionControl()
        {
            InitializeComponent();
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

        public int checkStatusWord()
        {

            //for(int i=0
            //  suggestWord 

            int chk;
            if ((status[status.Length - 1] == "0") || status.Length > 1)
            {
                chk = 1;

            }

            else
            {
                chk = 0;
            }
            return chk;
        }
        public void splitData(string splt)
        {
            // char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            char[] delimiterChars = { '|' };

            //  string text = "one\ttwo three:four,five six seven";
            //   System.Console.WriteLine("Original text: '{0}'", splt);

            string[] words = splt.Split(delimiterChars);
            suggestWord = new string[words.Length / 2];
            status = new string[words.Length / 2];
            //  System.Console.WriteLine("{0} words in text:", words.Length);
            int counts = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                // Console.WriteLine("word-->{0}", words[i]);
                //   if (i % 2 == 0)
                // {
                suggestWord[counts] = words[i];
                // }
                //else if (i / 2 == 1)
                //{
                status[counts] = words[i + 1];
                //}
                //Console.WriteLine("sugg-->{0}", suggestWord[counts]);
                // Console.WriteLine("status-->{0}", status[counts]);
                counts++;
                i++;

            }


        }


        public int ListCount(string word,int statusWord)
        {

            //int countWord=0;
            logger.Debug("Suggest For: {0}", word);
            wsType = WordSuggestType.None;
            searchWord = word;
            List<string> acl = ac.AutoComplete(word, NumOfComplete);
            LDUtils.printList(acl, "Auto Complete");
            if (acl.IndexOf(word) == -1 || statusWord==1)
            {
               // lbWordSuggest.DataSource = acl;
               // wsType = WordSuggestType.AutoComplete;
                return acl.Count;
            }
            else
            {
                List<string> pl = pd.Predict(word, NumOfPredict);
               // lbWordSuggest.DataSource = pl;
               // wsType = WordSuggestType.Prediction;
               // LDUtils.printList(pl, "Prediction");
                return pl.Count;
            }
           // return 0;
        }



        public void ListSuggest(string word)
        {
            logger.Debug("Suggest For: {0}", word);
            wsType = WordSuggestType.None;
            searchWord = word;
            List<string> acl = ac.AutoComplete(word, NumOfComplete);
            LDUtils.printList(acl, "Auto Complete");
         //   Console.WriteLine("word-->"+word);
         //   Console.WriteLine("acl.IndexOf-->" + acl.IndexOf(word));
            if (acl.IndexOf(word) == -1)
            {
                lbWordSuggest.DataSource = acl;
                wsType = WordSuggestType.AutoComplete;
               // Console.WriteLine("complete-->"+word);
            }
            else
            {
                List<string> pl = pd.Predict(word, NumOfPredict);
                lbWordSuggest.DataSource = pl;
                wsType = WordSuggestType.Prediction;
                LDUtils.printList(pl, "Prediction");
               // Console.WriteLine("prediction-->" + word);
            }
        }

        public void ListSuggest(string word,int statusWord)
        {
            logger.Debug("Suggest For: {0}", word);
            wsType = WordSuggestType.None;
            searchWord = word;
            List<string> acl = ac.AutoComplete(word, NumOfComplete);
            LDUtils.printList(acl, "Auto Complete");
            //Console.WriteLine("word-->" + word);
           // Console.WriteLine("acl.IndexOf-->" + acl.IndexOf(word));
            if (acl.IndexOf(word) == -1 || statusWord==1)
            {
                lbWordSuggest.DataSource = acl;
                wsType = WordSuggestType.AutoComplete;
             //   Console.WriteLine("complete-->" + word);
            }
            else
            {
                List<string> pl = pd.Predict(word, NumOfPredict);
                lbWordSuggest.DataSource = pl;
                wsType = WordSuggestType.Prediction;
                LDUtils.printList(pl, "Prediction");
               // Console.WriteLine("prediction-->" + word);
            }
        }

        public void Clear()
        {
            lbWordSuggest.DataSource = null;
        }

        private void lbWordSuggest_DoubleClick(object sender, EventArgs e)
        {
            if (lbWordSuggest.SelectedIndex >= 0)
            {
                if (SelectWordSuggestEvent != null)
                {
                    string selected = (string)lbWordSuggest.SelectedValue;
                    SelectWordSuggestEvent(searchWord, selected, wsType);

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
        }

        private void lbWordSuggest_Click(object sender, EventArgs e)
        {
            if (lbWordSuggest.SelectedIndex > -1)
            {
                string s = (string)lbWordSuggest.SelectedValue;
                if (s != null)
                {
                    LDDictionary dict = new LDDictionary();
                   // txtMeaning.Text = dict.Lookup(s);
                     
                    if (Reader != null)
                    {
                        Reader.Text = s;
                        Reader.Play();
                    }
                }
            }
        }
    }
}
