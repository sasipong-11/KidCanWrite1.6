using LDWordProcessor.genius;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordProcLD;

namespace LDWordProcessor.db
{
    public class LDwordChecker
    {
        private LDSpellChecker iSpellChecker;
        private List<MisSpellingEntry> iMisSpellls;
        public LDwordChecker()
        {
           // iSpellChecker = new LDSpellChecker();
        }
        public List<MisSpellingEntry> SpellCheck(string Text)
        {
            //segment word
            LDWordSegment wseg = new LDWordSegment();
            string strSegment = wseg.GetWordSegment(Text);
           
            iMisSpellls.Clear();
            WordSegmentEntry[] wsList = wseg.GetWordSegmentPos(Text, strSegment);
            SpellCheckerIgnore ignoreList = iSpellChecker.IgnoreList;
            UserDict userDict = Program.AuthUser.UserDict;
            SpellChkLib spellChkLib = NectecAPI.Instance.SpellCheck;
            SegmentSolution seg = new SegmentSolution(wsList, iSpellChecker);
            string ret = seg.segmentOpterated();
            WordSegmentEntry[] wsList1 = wseg.GetWordSegmentPos(Text, ret);
            return iMisSpellls;
        }
    }
}
