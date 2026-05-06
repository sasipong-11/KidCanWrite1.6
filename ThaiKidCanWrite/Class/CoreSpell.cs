using System;
using System.Collections.Generic;

#pragma warning disable 0169

namespace WordProcLD
{
    class CoreSpellLib
    {
        private SpellingLib _th, _en;
        private HomophoneLib _homo;
        public List<string> result;
        public CoreSpellLib()
        {
            _th = new SpellingLib("th", Environment.CurrentDirectory);
            //_en = new SpellingLib("en", Environment.CurrentDirectory);
            _homo = new HomophoneLib(Environment.CurrentDirectory);
            result = new List<string>();
        }
        /** Spelllib **/
        public List<string> getSpell(string word,string g2p)
        {
            this.result = _th.GetSpellLD(word);
            if (this.result.Count == 0) { this.result = _th.GetSpellMore(word); }
            this.result = MergeArr(_homo.Homophone(word, g2p), this.result);
            return this.result;
        }
        /** get last spell **/
        public List<string> getSpellLast()
        {
            return this.result;
        }
        /** Database Default  **/
        public bool setDefault()
        {
            return _homo.Default();
        }
        /** Del data in Database  **/
        public bool Del(string word)
        {
            return _th.Del(word);
        }
        /** Database Maintenance **/
        public bool Maintenance()
        {
            return _th.Maintenance();
        }
        /** add word to Database **/
        public bool Update(string word,string wHomo, string g2p)
        {
            return _homo.Update(word, wHomo, g2p);
        }
        public bool Update(string word, string g2p)
        {
            if (word == "" || g2p == "") return false;
            return _homo.Update("",word, g2p);
        }
        private List<string> MergeArr( List<string> listBase,  List<string> listAdd)
        {
            List<string> listMerge = new List<string>();
            // Add base string soundex 
            foreach (string str in listBase)
                listMerge.Add(str);
            // Add and Merge soundex & apporx
            foreach (string str in listAdd)
            {
                if (listMerge.Contains(str) == false)
                    listMerge.Add(str);
            }
            return listMerge;
        }
        public bool checkInDict(string word)
        {
            if (word == "") return false;
            return _homo.DictCheck(word);
        }
    }
}
