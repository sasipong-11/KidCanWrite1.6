using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LDWordProcessor
{
    public class MisSpellingEntry
    {
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private int start;
        private SuggestType type = SuggestType.Unknown;
        private SpellWordSuggestEntry[] suggestWords;
        private LDParagraph parent;

        public MisSpellingEntry(LDParagraph parent, int index, string text, int start)
        {
            this.index = index;
            this.text = text;
            this.start = start;
            this.parent = parent;
        }

        public LDParagraph Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        private MisSpellState state = MisSpellState.Error;

        public MisSpellState State
        {
            get { return state; }
            set { state = value; }
        }

        public SpellWordSuggestEntry[] SuggestWords
        {
            get { return suggestWords; }
            set { suggestWords = value; }
        }

        public SuggestType Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Start
        {
            get { return start; }
            set { start = value; }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public bool IsError
        {
            get { return State == MisSpellState.Error; }
        }

        public bool IsInRage(int pos)
        {
            return IsError && pos >= Start && pos <= (Start + Length);
        }

        public int Length
        {
            get { return Text.Length; }
        }

        public void SetIgnore(bool value)
        {
            if (value)
            {
                State = MisSpellState.Ignore;
                //Parent.Ignore(this);
            }
        }

        public void Replace(string newWord)
        {
            //Parent.Replace(this, newWord);
            State = MisSpellState.Correct;
            Text = newWord;
        }

        public string TypeStr()
        {
            string str = "unknown";
            switch (Type)
            {
                case SuggestType.Approx:
                    str = "Approx";
                    break;
                case SuggestType.Soundex:
                    str = "soundex";
                    break;
            }

            return str;
        }
    }
}
