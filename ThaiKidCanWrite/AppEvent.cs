using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LDWordProcessor
{
    public delegate void SelectWordSuggestEventHandler(string sWordStart, string sWordComplete, WordSuggestType wordSuggestType);
    public delegate void CompleteEventHandler(string sWordStart, string sWordComplete);
    public delegate void PredictEventHandler(string sWordStart, string sWordPredict);
}
