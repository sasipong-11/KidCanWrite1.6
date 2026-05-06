using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit;
using System.Security.Cryptography;
using NLog;
using LDWordProcessor.genius;
using WordProcLD;
using System.Diagnostics;

namespace LDWordProcessor
{
    public enum LDParagraphState
    {
        Uncheck,
        Changing,
        Checked
    }

    public class LDParagraph
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Document iDoc;
        private Paragraph iParagraph;
        private LDParagraphState iState;
        private LDSpellChecker iSpellChecker;
        private int iParagraphIndex;
        private List<MisSpellingEntry> iMisSpellls;
        private Boolean bModified = false;
        private string sText;
        private static object syncLock = new object();

        public LDParagraph(LDSpellChecker checker, Document doc, Paragraph p)
        {
            //Replace by the new version of spell checker
            //iSpellChecker = checker;
            iDoc = doc;
            iParagraph = p;
            iState = LDParagraphState.Uncheck;
            iParagraphIndex = p.Index;
            iMisSpellls = new List<MisSpellingEntry>();
            Text = doc.GetText(p.Range);
        }

        public LDParagraph(LDSpellChecker checker, Document doc, Paragraph p, RichEditControl richEdit = null)
        {
            iSpellChecker = checker;
            iDoc = doc;
            iParagraph = p;
            iState = LDParagraphState.Uncheck;
            iParagraphIndex = p.Index;
            iMisSpellls = new List<MisSpellingEntry>();
            if (richEdit != null)
            {
                Text = (string)richEdit.Invoke(new Func<string>(() => richEdit.Document.GetText(p.Range)));
            }
            else
            {
                Text = doc.GetText(p.Range);
            }
        }

        public List<MisSpellingEntry> SpellCheck()
        {
            //segment word
            LDWordSegment wseg = new LDWordSegment();
            string strSegment = wseg.GetWordSegment(Text);
            logger.Debug("MD5:{0}", Text);
            logger.Debug("strSegment:{0}", strSegment);
            iMisSpellls.Clear();
            WordSegmentEntry[] wsList = wseg.GetWordSegmentPos(Text, strSegment);
            SpellCheckerIgnore ignoreList = iSpellChecker.IgnoreList;
           // UserDict userDict = Program.AuthUser.UserDict;
            SpellChkLib spellChkLib = NectecAPI.Instance.SpellCheck;
            //spell check each entry

            //      Console.WriteLine("strSegment-->{0}", strSegment);
            //   Console.WriteLine("Text-->{0}", Text);

            //   MessageBox.Show("before-->",
            // strSegment.ToString());
            // Console.WriteLine("strSegment-->{0}", strSegment);
            SegmentSolution seg = new SegmentSolution(wsList, iSpellChecker);
            string ret = seg.segmentOpterated();
            //  Console.WriteLine("ret-->{0}", ret);
            //   MessageBox.Show("after-->",
            //   ret.ToString());
            WordSegmentEntry[] wsList1 = wseg.GetWordSegmentPos(Text, ret);

            foreach (WordSegmentEntry ws in wsList1)
            {
               /* if (ws.IsThaiWord())
                {
                    int offset = this.Paragraph.Range.Start.ToInt();
                    string selectText = ws.text;

                    if (!ignoreList.Exist(selectText, ws.start) &&
                        !userDict.Exist(selectText) &&
                        (!spellChkLib.DictCheck(selectText)))
                    {
                        string wrongWord = selectText.Trim();

                        MisSpellingEntry entry = new MisSpellingEntry(this, iMisSpellls.Count, selectText, ws.startNonLF);
                        if (LDSuggestWord.GetSuggestLDWords(wrongWord).Count() > 1)
                        {
                            entry.SuggestWords = LDSuggestWord.GetSuggestLDWords(wrongWord);

                        }
                        else
                        {
                            entry.SuggestWords = LDSuggestWord.GetSuggestWords(wrongWord);
                        }
                        entry.Type = SuggestType.Unknown;
                        if (entry.SuggestWords.Length > 0)
                        {
                            entry.Type = entry.SuggestWords[0].Type;
                        }

                        iMisSpellls.Add(entry);
                    }
                }*/

                if (ws.IsThaiWord())
                {
                    int offset = this.Paragraph.Range.Start.ToInt();
                    string selectText = ws.text;

                    if (!ignoreList.Exist(selectText, ws.start) &&
                        (!spellChkLib.DictCheck(selectText)))
                    {
                        string wrongWord = selectText.Trim();

                        MisSpellingEntry entry = new MisSpellingEntry(this, iMisSpellls.Count, selectText, ws.startNonLF);
                        if (LDSuggestWord.GetSuggestLDWords(wrongWord).Count() >= 1)
                        {
                            // entry.SuggestWords = LDSuggestWord.GetSuggestLDWords(wrongWord);
                            int cp1 = 0;
                            entry.SuggestWords = LDSuggestWord.GetSuggestLDWords(wrongWord);
                            for (int cp = 0; cp < entry.SuggestWords.Count(); cp++)
                            {
                                //  Console.WriteLine("suggest-->{0}", entry.SuggestWords[1].Text.ToString());

                                if (entry.SuggestWords[cp].Text.Length >= wrongWord.Length)
                                {
                                    cp1++;
                                }

                            }

                            if (cp1 == 0)
                            {
                                entry.SuggestWords = LDSuggestWord.GetSuggestWords(wrongWord);
                            }
                            else if (((entry.SuggestWords.Count() < 3) && (cp1 == 0)))
                            {
                                entry.SuggestWords = LDSuggestWord.GetSuggestWords(wrongWord);
                            }
                        }
                        else
                        {
                            entry.SuggestWords = LDSuggestWord.GetSuggestWords(wrongWord);
                        }
                        entry.Type = SuggestType.Unknown;
                        if (entry.SuggestWords.Length > 0)
                        {
                            entry.Type = entry.SuggestWords[0].Type;
                        }

                        iMisSpellls.Add(entry);
                    }
                }
            }

            return iMisSpellls;
        }

        public void Ignore(MisSpellingEntry m)
        {
            SpellCheckerIgnore ignoreList = iSpellChecker.IgnoreList;
            m.State = MisSpellState.Ignore;
            ignoreList.AddIgnore(m);
            Modified = true;
        }

        public void IgnoreAll(MisSpellingEntry m)
        {
            SpellCheckerIgnore ignoreList = iSpellChecker.IgnoreList;
            iSpellChecker.IgnoreList.AddIgnoreAll(m);
            ignoreList.AddIgnoreAll(m);
            Modified = true;
        }

        public void Replace(MisSpellingEntry m, string replaceText)
        {
            m.State = MisSpellState.Correct;
            int diffLength = replaceText.Length - m.Length;
            for (int i = m.Index+1; i < iMisSpellls.Count; i++)
            {
                MisSpellingEntry m0 = iMisSpellls[i];
                int start = m0.Start + diffLength;
                if (start >= 0)
                {
                    m0.Start = start;
                }
            }
            Modified = true;
        }

        public void UpdateChangeText(String newText)
        {
            iDoc.Replace(Paragraph.Range, newText + "\n");
        }

        public bool HasMisSpell()
        {
            foreach (var m in iMisSpellls)
            {
                if (m.State == MisSpellState.Error)
                {
                    return true;
                }
            }

            return false;
        }

        #region Property

        public string Text
        {
            get { return sText; }
            set { sText = value; }
        }

        public string MD5
        {
            get { return MD5Helper.GetMd5Hash(Text); }
        }

        public LDParagraphState State
        {
            get { return iState; }
            set { iState = value; }
        }

        public Paragraph Paragraph
        {
            get { return iParagraph; }
        }

        public Boolean Modified
        {
            get { return bModified; }
            set { bModified = value; }
        }

        #endregion
    }

}
