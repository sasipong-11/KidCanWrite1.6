using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Utils;
using LDWordProcessorLib;
using NLog;
using WordProcLD;

namespace LDWordProcessor
{
    public class RichEditHelper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private RichEditControl iRichEdit;
        private int iStartCaretPos { get; set; }
        private uint iLastKeyTime { get; set; }
        private StringBuilder iNewInput;
        private StringBuilder iInputBuf;
        ContextMenu mnuContextMenu = new ContextMenu();

        public RichEditHelper(RichEditControl richEdit)
        {
            iRichEdit = richEdit;
            iStartCaretPos = -1;
            iNewInput = new StringBuilder();
            iInputBuf = new StringBuilder();
        }

        public RichEditControl RictEditControl
        {
            get { return iRichEdit; }
            set { iRichEdit = value; }
        }

        public void AppendNewInput(char c)
        {
            if ((int)c == 8)
            {
                if (iInputBuf.Length > 0)
                    iInputBuf.Remove(iInputBuf.Length - 1, 1);
            }
            else if ((int)c > 32)
            {
                iInputBuf.Append(c);
            }
        }

        public void RemoveLast()
        {
            logger.Debug("Remove last [{0}]", iInputBuf.ToString());
            //iInputBuf = iInputBuf.Remove(iInputBuf.Length - 1, 1);
        }

        public void ResetNewInput()
        {
            iInputBuf.Clear();
        }

        public String GetNewInput()
        {
            String s = iInputBuf.ToString().Trim();

            //foreach (char ch in s.ToCharArray())
            //{
            //    logger.Debug("{0} = {1}", ch, (int)ch);
            //}
            iInputBuf.Clear();
            return s;
        }

        public void PerformNewInput()
        {
            iNewInput.Append(InternalNewInput());
        }

        public bool HasNewInput()
        {
            return iInputBuf.Length > 0;
        }


        private String InternalNewInput()
        {
            if (iStartCaretPos >= 0)
            {
                Document doc = iRichEdit.Document;
                int stopPos = doc.CaretPosition.ToInt();
                DocumentPosition startPos = doc.CreatePosition(iStartCaretPos);
                DocumentRange range = doc.CreateRange(startPos, stopPos);
                //logger.Debug("Token input [{0},{1}]", startPos.ToInt(), stopPos);
                return doc.GetText(range);
            }
            return "";
        }

        public String GetLastCharInput()
        {
            Document doc = iRichEdit.Document;
            int nPos = (doc.CaretPosition.ToInt() > 0 ? doc.CaretPosition.ToInt() - 1 : 0);
            DocumentPosition pos = doc.CreatePosition(nPos);
            DocumentRange range = doc.CreateRange(pos, 1);
            return doc.GetText(range);
        }

        public bool IsLetterLastChar()
        {
            String s = GetLastCharInput();
            if (s.Length > 0)
            {
                return Char.IsLetter(s[0]);
            }
            return false;
        }

        public void StartNewInput(bool isKeyMove = false)
        {
            iStartCaretPos = iRichEdit.Document.CaretPosition.ToInt();
            if (isKeyMove)
            {
                if (iStartCaretPos > 0)
                {
                    iStartCaretPos--;
                }
            }
            iNewInput.Clear();
            iInputBuf.Clear();
        }

        public void ResetKeyIdle()
        {
            iLastKeyTime = User32Dll.GetTickCount();
        }

        public bool IsNewInput()
        {
            uint timeColaps = User32Dll.GetTickCount() - iLastKeyTime;
            logger.Debug("Time passed: " + (timeColaps / 1000));
            return (((timeColaps) / 1000) > 1);
        }

        public bool IsKeyIdle()
        {
            uint timeColaps = User32Dll.GetTickCount() - iLastKeyTime;
            bool ret = timeColaps > 500; // 500 ms  (((timeColaps) / 1000) > 1);
            if (ret) PerformNewInput();

            return ret;
        }

        public DocumentSelection GetSelectedText()
        {
            Document doc = iRichEdit.Document;
            string str = doc.GetText(doc.Selection);
            return new DocumentSelection(str, doc.Selection.Start.ToInt(), str.Length);
        }

        public DocumentSelection GetCurrTextSentence()
        {
            return DocumentHelper.GetCurrTextSentence(iRichEdit.Document);
        }

        public DocumentSelection GetTextToEndFromPosition()
        {

            Document doc = iRichEdit.Document;
            DocumentRange range1 = doc.CreateRange(doc.CaretPosition.ToInt(), doc.Length - doc.CaretPosition.ToInt());
            string s = doc.GetText(range1);
            int pageBreak = s.IndexOf('\f');
            int length = range1.Length;
            logger.Debug("Read Here - str: [{3}] caret:{0}, substr:{1} strlen:{2}", doc.CaretPosition.ToInt(), s, s.Length, iRichEdit.Text);
            return new DocumentSelection(s, range1.Start.ToInt(), length);
        }

        public DocumentSelection GetTextParagraph()
        {
            return DocumentHelper.GetTextParagraph(iRichEdit.Document);
        }

        public List<string> GetTextParagraphs()
        {
            return DocumentHelper.GetTextParagraphs(iRichEdit.Document);
        }

        public void Select(int start, int len)
        {
            DocumentHelper.Select(iRichEdit.Document, start, len);
        }

        public void Select(LDReaderItem item)
        {
            DocumentHelper.Select(iRichEdit.Document, item.Start, item.End - item.Start);
        }

        public void SelectLD(int start, int len)
        {
            DocumentHelper.Select(iRichEdit.Document, start, len);
            iRichEdit.ScrollToCaret();
        }

        public void ResetCharacterHilight()
        {
            DocumentHelper.ResetTextHilight(iRichEdit.Document, iRichEdit.Document.CaretPosition.ToInt()-1, 1);
        }

        public string GetLastTextInput()
        {
            return DocumentHelper.GetLastTextInput(iRichEdit.Document);
        }

        public void InsertText(string text)
        {
            if (text.Length > 0)
            {
                DocumentPosition pos = (iRichEdit.Document.CaretPosition);
                iRichEdit.Document.InsertText(pos, text);
            }
        }

    }
}