using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordProcLD;
using NLog;
using Microsoft.VisualBasic;
using api;

namespace LDWordProcessor
{
    public class LDDictionary
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private DictionaryLib d;

        public LDDictionary()
        {
            d = NectecAPI.Instance.Dict;
        }

        public int GetUnknownWords(string[] words, List<string> unknowns)
        {
            unknowns.Clear();
            foreach (string w in words)
            {
                if (w.Length > 0 && !IsExist(w))
                {
                    unknowns.Add(w);
                }
            }
            return unknowns.Count;
        }
        public string Lookup(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var s in d.Dictionary(word))
            {
                int i = s.IndexOf('[');
                if (i > 0)
                {
                    sb.AppendLine(s.Substring(i-1));
                }
                else
                {
                    sb.AppendLine(s);
                }
            }
            //sb.AppendLine();
            //foreach (var t in d.DictionaryDetail(word))
            //{
            //    sb.Append(t.Key + "\t" + t.Value);
            //}
            return sb.ToString();
        }

        public bool IsExist(string word)
        {
            if (word.Length > 0)
            {
                try
                {
                    List<string> dl = d.Dictionary(word);
                    //logger.Debug("Lookup - {0}", word);
                    //LDUtils.printList(dl);
                    if (dl.Count == 1)
                    {
                        if (dl[0] == "ไม่มีความหมาย")
                            return false;
                    }

                    return dl.Count > 0;
                }
                catch (Exception e)
                {
                    logger.ErrorException(e.Message, e);
                }
            }
            return false;
        }

    }
}
