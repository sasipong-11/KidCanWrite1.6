using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Threading;

namespace LDWordProcessor
{
    class ReaderParagraph
    {
        private string _text;
        private int _position;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        
        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public int Length
        {
            get { return _text.Length; }
        }
    }

    class ReaderParagraphList
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private List<ReaderParagraph> list;
        private int curPos;
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public ReaderParagraphList()
        {
            list = new List<ReaderParagraph>();
            curPos = -1;
        }

        public void SetText(string str, int maxChars){
            int strLen = str.Length;
            int subStart = 0;

            while (subStart != -1)
            {
                int subLen = maxChars;
                if (subLen + subStart > strLen)
                {
                    subLen = strLen - subStart;
                }

                string subStr = str.Substring(subStart, subLen);
                logger.Debug("try: str={0}, start={1}, len={2}", subStr, subStart, subStr.Length);
                ReaderParagraph paragraph = new ReaderParagraph();
                int i = subStr.LastIndexOf(" ");
                if (i > 0)
                {
                    paragraph.Text = subStr.Substring(0, i);
                    paragraph.Position = subStart;
                    subStart = subStart+ i + 1;
                }
                else //no space in text
                {
                    paragraph.Text = subStr;
                    paragraph.Position = subStart;
                    subStart = -1;
                }
                list.Add(paragraph);
                logger.Debug("accept: str={0}, start={1}, len={2}", subStr, subStart, subStr.Length);
            }
        }

        public ReaderParagraph GetParagraph(int curPos)
        {
            foreach (var p in list)
            {
                logger.Debug("curPos={0}, p={1}", curPos, p.Position + p.Length);
                if (curPos <= p.Position+p.Length)
                {
                    return p;
                }
            }
            return null;
        }

        public string Next()
        {
            curPos++;
            return list[curPos].Text;
        }

        public bool HasNext()
        {
            return curPos < list.Count - 1;
        }

        public void reset()
        {
            curPos = -1;
        }

        public void Clear()
        {
            reset();
            list.Clear();
        }
    }

    class ReaderDisplayText
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string sText;
        private StringBuilder buffer = new StringBuilder();
        private ReaderContrl _parent;
        private ReaderParagraphList pList = new ReaderParagraphList();
        private bool isParagraph;

        public bool IsParagraph
        {
            get { return isParagraph; }
            set { isParagraph = value; }
        }

        public ReaderDisplayText(ReaderContrl parent)
        {
            _parent = parent;
        }

        public DevExpress.XtraEditors.LabelControl Display
        {
            get { return _parent.lbText; }
        }

        public string Text
        {
            get { return sText; }
            set { 
                sText = value;
                _parent.lbText.Text = sText;
                IsParagraph = false;
            }
        }

        public string TextParagraph
        {
            get { return sText; }
            set
            {
                sText = value;
                _parent.lbText.Text = sText;
                IsParagraph = true;
                pList.SetText(sText, MAX_CHARS);
            }
        }

        private const int MAX_CHARS = 60;
        private const string HILIGHT_START_TAG = "<color=\"orange\">";
        private const string HILIGHT_END_TAG = "</color>";
        private int iFontSize = 0;
        private const int MAX_FONT_SIZE = 24;
        private int iPos, iLength;

        public void OnWordChanged(int pos, int length)
        {
            iPos = pos;
            iLength = length;
            PerformText();
            Refresh();
        }

        private void PerformText()
        {
            buffer.Clear();
            if (IsParagraph)
            {
                ReaderParagraph p = pList.GetParagraph(iPos);
                if (p != null)
                {
                    buffer.Append(p.Text);

                    int pos = iPos - p.Position;
                    buffer.Insert(pos, HILIGHT_START_TAG);
                    buffer.Insert(pos + iLength + HILIGHT_START_TAG.Length, HILIGHT_END_TAG);

                    buffer = AddHTMLDecoration(buffer);
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder(sText);
                String newStr = sb.Insert(iPos, HILIGHT_START_TAG).ToString();
                sb.Clear();
                sb.Append(newStr);
                int endPos = iPos + iLength + HILIGHT_START_TAG.Length;
                buffer = sb.Insert(endPos, HILIGHT_END_TAG);

                buffer = AddHTMLDecoration(buffer);     
            }
        }

        public void Refresh()
        {
            _parent.Invoke((System.Windows.Forms.MethodInvoker)delegate
            {
                Display.Text = buffer.ToString();
            });
        }

        private StringBuilder AddHTMLDecoration(StringBuilder sb)
        {
            sb.Insert(0, "<b>").Append("</b>");
            if (iFontSize > 0)
            {
                sb.Insert(0, "<size=+" + iFontSize + ">").Append("</size>");
            }
            else if (iFontSize < 0)
            {
                sb.Insert(0, "<size=-" + iFontSize + ">").Append("</size>");
            }

            return sb;
        }

        public void IncreaseFont()
        {
            if (iFontSize < MAX_FONT_SIZE) {
                string s = Display.Text;
                buffer.Clear();
                buffer.Append(s.Replace("<size=+" + iFontSize + ">", "<size=+" + (iFontSize + 2) + ">"));
                iFontSize += 2;
                _parent.Height += 3;
                Refresh();
            };
        }

        public void DecreaseFont()
        {
            if (iFontSize > 0) {
                string s = Display.Text;
                buffer.Clear();
                buffer.Append(s.Replace("<size=-" + iFontSize + ">", "<size=+" + (iFontSize - 2) + ">"));
                iFontSize -= 2;
                _parent.Height -= 3;
                Refresh(); 
            };
        }
    }
}
