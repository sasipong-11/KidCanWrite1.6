using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordProcLD;
using api;
using NLog;
using System.Windows.Forms;

namespace LDWordProcessor
{
    public class NectecAPI
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static NectecAPI instance;
        private AutoCompleteLib ac;
        private SpellingLib spl;
        private PredictLib pd;
        private SpellChkLib splchk;
        private DictionaryLib dict;
        private HomophoneLib homo;
        private MainAnalysis wseg;

        private NectecAPI()
        {
            string exeAppPath = Environment.CurrentDirectory;
            try{
                ac = new AutoCompleteLib(exeAppPath);
                spl = new SpellingLib("th", exeAppPath);
                pd = new PredictLib(exeAppPath);
                splchk = new SpellChkLib(exeAppPath);
                dict = new DictionaryLib(exeAppPath);
                homo = new HomophoneLib(exeAppPath);
                wseg = new MainAnalysis();
            }
            catch (Exception e)
            {
                logger.Error(e);
            }
        }

        public static NectecAPI Instance
        {
            get {
                if (instance == null)
                {
                    instance = new NectecAPI();
                }

                return instance; 
            }
        }

        public AutoCompleteLib AutoComplete
        {
            get { return ac; }
        }

        public SpellingLib Spelling
        {
            get { return spl; }
        }

        public PredictLib Predict
        {
            get { return pd; }
        }

        public SpellChkLib SpellCheck
        {
            get { return splchk; }
        }

        public DictionaryLib Dict{
            get { return dict; }
        }

        public MainAnalysis WordSegment
        {
            get { return wseg; }
        }

        public HomophoneLib HomoPhone
        {
            get { return homo; }
        }


    }
}
