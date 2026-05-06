using System;
using System.Collections.Generic;

namespace WordProcLD
{
    class CoreAutoComplete
    {
        private AutoCompleteLib _auto;
        public List<string> result;
        public CoreAutoComplete()
        {
            _auto = new AutoCompleteLib(Environment.CurrentDirectory);
            result = new List<string>();
        }
        /** AutoComplete **/
        public List<string> getAutoComplete(string str)
        {
            this.result = _auto.AutoComplete(str);
            return this.result;
        }
        /** AutoComplete limit list **/
        public List<string> getAutoComplete(string str,int num)
        {
            this.result = _auto.AutoComplete(str, num);
            return this.result;
        }
        /** Database Default  **/
        public bool setDefault()
        {
            return _auto.Default();
        }
        /** Del data in Database  **/
        public bool Del(string word)
        {
            return _auto.Del(word);
        }
        /** Database Maintenance **/
        public bool Maintenance()
        {
            return _auto.Maintenance();
        }
        /** add word to Database **/
        public bool Update(string str, string word)
        {
            if (word == "" && str == "") return false;
            return _auto.Update(str,word);
        }
        public bool checkInDict(string word)
        {
            if (word == "") return false;
            return _auto.DictCheck(word);
        }
    }
}
