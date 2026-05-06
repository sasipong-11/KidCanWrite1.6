using System;
using System.Collections.Generic;


namespace WordProcLD
{
    class CorePerdict
    {
        private PredictLib _predict;
        public List<string> result;
        public CorePerdict()
        {
            _predict = new PredictLib(Environment.CurrentDirectory);
            result = new List<string>();
        }
        /** PredictLib **/
        public List<string> getPredict(string str)
        {
            this.result = _predict.Predict(str);
            return this.result;
        }
        /** PredictLib limit list **/
        public List<string> getPredict(string str, int num)
        {
            this.result = _predict.Predict(str, num);
            return this.result;
        }
        /** Database Default  **/
        public bool setDefault()
        {
            return _predict.Default();
        }
        /** Del data in Database  **/
        public bool Del(string word,string wPredict)
        {
            return _predict.Del(word,wPredict);
        }
        /** Database Maintenance **/
        public bool Maintenance()
        {
            return _predict.Maintenance();
        }
        /** add word to Database **/
        public bool Update(string word, string wPredict)
        {
            if (word == "" || wPredict == "") return false;
            return _predict.Update(word, wPredict);
        }
    }
}
