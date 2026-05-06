using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LDWordProcessor.db
{
    class SHighlightData
    {
       private int _start, _len;
       private string  _text;
       private string[] _suggestWord;

       public int start
        {
            get { return _start; }
            set { _start = value; }
        }
       public int len
        {
            get { return _len; }
            set { _len = value; }
        }
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        public string[] suggestWord
        {
            get { return _suggestWord; }
            set { _suggestWord = value; }
        }
    }
    class SSuggestWord
    {
        string _text;
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

    }
}
