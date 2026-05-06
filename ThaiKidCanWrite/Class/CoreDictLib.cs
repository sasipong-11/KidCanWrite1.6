using System;
using System.Collections.Generic;

namespace WordProcLD
{
    class CoreDictLib
    {
        private DictionaryLib _dict;
        public List<string> result;
        public CoreDictLib()
        {
            _dict = new DictionaryLib(Environment.CurrentDirectory);
            result = new List<string>();
        }

        public List<string> getDict(string word)
        {
            //try
            //{
                this.result = _dict.Dictionary(word);
                return this.result;
            //}
            //catch
            //{
            //    this.result.Add("ไม่มีความหมาย");
            //    return this.result;
            //}
        }

        public List<string> getDictLast()
        {
                return this.result;
        }
    }
}
