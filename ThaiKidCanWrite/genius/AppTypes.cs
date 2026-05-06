using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace LDWordProcessor
{
    public enum ExitFormResult
    {
        None = 0,
        Cancel = 1,
        CloseDoc = 2,
        ExitApp = 3,
    }

    public enum ReadTextType
    {
        None,
        ReadHere,
        ReadSentence,
        ReadParagraph,
        ReadSelected,
    }

    public enum PopupCommandType
    {
        None,
        Replace,
        Ignore,
        IgnoreAll,
        CustomEdit,
        AddToDict,
        MoreDialog,
        Paste,
        Read,
    }

    public enum SuggestType
    {
        Unknown,
        Soundex,
        Approx
    }

    public enum MisSpellState
    {
        None,
        Error,
        Correct,
        Ignore,
    }

    public class LDReaderItem
    {
        public string Text;
        public int Start;
        public int End;

        public bool IsCaretInside(int caretPos)
        {
            return caretPos >= Start && caretPos <= End;
        }
    }

    public class PopupCommand
    {
        public PopupCommandType Type = PopupCommandType.None;
        public Object Tag;

        public PopupCommand(PopupCommandType type, Object tag)
        {
            Type = type;
            Tag = tag;
        }
    }

    public class SpellWordSuggestEntry
    {
        public string Text;
        public SuggestType Type = SuggestType.Unknown;
    }

    public class SpellWordIgnoreEntry
    {
        public string Text;
        public int Position;
        public bool IsNew = false;
        public SpellWordIgnoreEntry(string text, int pos, bool is_new=false)
        {
            Text = text;
            Position = pos;
            IsNew = is_new;
        }
    }

    public class ReplaceWordEntry
    {
        private MisSpellingEntry _misSpellingEntry;

        public MisSpellingEntry MisSpellingEntry
        {
            get { return _misSpellingEntry; }
            set { _misSpellingEntry = value; }
        }
        public SpellWordSuggestEntry NewWord;

        public ReplaceWordEntry(MisSpellingEntry misSpellingEntry, SpellWordSuggestEntry newWord)
        {
            this._misSpellingEntry = misSpellingEntry;
            this.NewWord = newWord;
        }
    }

    public class UserDictEntry : IComparable
    {
        public string Word;
        public bool IsNew;

        public UserDictEntry(string word, bool isNew)
        {
            Word = word;
            IsNew = isNew;
        }

        public int CompareTo(object obj)
        {
            UserDictEntry u = (UserDictEntry)obj;
            return String.Compare(this.Word, u.Word);
        }
    }

    public class WordSegmentEntry
    {
        public string text;
        public int start;
        public int length;
        public int startNonLF;

        public WordSegmentEntry()
        {
        }

        public WordSegmentEntry(string text, int start, int length)
        {
            this.text = text;
            this.start = start;
            this.length = length;
        }

        public bool IsThaiWord()
        {
            Trace.WriteLine("IsThaiWord?");
            return (text.Trim().Count() > 1) && !IsNumeric(text);// && IsThaiChar(text);
        }

        public static Boolean IsNumeric(string stringToTest)
        {
            int result;
            return int.TryParse(stringToTest, out result);
        }

        public static Boolean IsThaiChar(string stringToTest)
        {
            char[] c = stringToTest.ToCharArray();
            if (c[0] >= 'ก')
            {
                return true;
            }

            return false;
        }
    }

    public class SpellCheckedEntry
    {
        public string MD5;
        public string Text;
        public bool IsNew;

        public SpellCheckedEntry(string md5, string text, bool isNew)
        {
            Text = text;
            MD5 = md5;
            IsNew = isNew;
        }
    }

    public enum WordSuggestType
    {
        None,
        AutoComplete,
        Prediction
    }

    public enum Page
    {
        None,
        Mindmap,
        Editword,
        Outline
    }
}
