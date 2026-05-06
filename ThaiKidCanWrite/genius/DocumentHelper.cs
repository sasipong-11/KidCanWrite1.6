using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit;
using NLog;

namespace LDWordProcessor
{
    public class DocumentSelection
    {
        public int Start;
        public int Length;
        public string Text;
        public int CaretPosition;

        public DocumentSelection()
        {
        }

        public DocumentSelection(string text, int start, int length)
        {
            Start = start;
            Text = text;
            Length = length;
        }
    }

    public static class DocumentHelper
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Select(Document doc, int start, int length)
        {
            if (doc != null)
            {
                DocumentPosition docStartPos = doc.CreatePosition(start);
                DocumentRange range = doc.CreateRange(docStartPos, length);
                doc.Selection = range;
            }
        }

        public static string GetLastTextInput(Document doc, int length = 100)
        {
            Paragraph p = doc.GetParagraph(doc.CaretPosition);
            int caret = doc.CaretPosition.ToInt();
            int start = p.Range.Start.ToInt();

            if (caret - start > length)
            {
                start = caret - length;
            }
            int len = caret - start;
            if (len > length) len = length;


            DocumentPosition docStart = doc.CreatePosition(start);
            DocumentRange range = doc.CreateRange(docStart, len);
            string str = doc.GetText(range);
            return str;
        }

        public static DocumentSelection GetCurrTextSentence(Document doc, int caretP)
        {

            Paragraph p = doc.GetParagraph(doc.CaretPosition);
            Console.WriteLine("CaretPosition-->" + caretP);
            int offset = p.Range.Start.ToInt();
            int caret = doc.CaretPosition.ToInt();

            string str = doc.GetText(p.Range);
            int relatePos = caret - offset;
            Console.WriteLine("str-->" + str);
            LDUtils.printChars(str.ToCharArray());

            bool needAdjust = false;
            if (relatePos < str.Length)
            {
                if (str[relatePos] == '\r' || str[relatePos] == '\n')
                {
                    needAdjust = true;
                    while (relatePos < str.Length)
                    {
                        if (!(str[relatePos] == '\r' || str[relatePos] == '\n'))
                        {
                            break;
                        }
                        relatePos++;
                    }
                }
            }

            int startToken = relatePos;

            if (startToken < str.Length)
            {

                if (!needAdjust)
                {
                    startToken = str.LastIndexOfAny(new char[] { ' ', '\r' }, relatePos);
                    if (startToken < 0) startToken = 0;
                }

                int endPos = str.IndexOfAny(new char[] { ' ', '\r' }, relatePos);
                if (endPos < 0) endPos = str.Length;

                logger.Debug("offset: {0} caret:{1} relpos: {2} startToken: {3} endToken: {4}", offset, caret, relatePos, startToken, endPos);

                string sentence = str.Substring(startToken, endPos - startToken);
                int cntLF = CountLineFeed(doc, offset, offset + startToken);
                int startHilight = offset + startToken - cntLF;

                return new DocumentSelection(sentence, startHilight, sentence.Length);
            }
            else //end of text
            {
                return new DocumentSelection("", 0, -1);
            }
        }


        public static DocumentSelection GetCurrTextSentence(Document doc)
        {

            Paragraph p = doc.GetParagraph(doc.CaretPosition);

            int offset = p.Range.Start.ToInt();
            int caret = doc.CaretPosition.ToInt() + 1;
            //Console.WriteLine("offset-->" + offset);
            //Console.WriteLine("CaretPosition-->" + caret);
            string str = doc.GetText(p.Range);
            int relatePos = caret - offset;
            // Console.WriteLine("str-->" + str);
            LDUtils.printChars(str.ToCharArray());

            bool needAdjust = false;
            if (relatePos < str.Length)
            {
                if (str[relatePos] == '\r' || str[relatePos] == '\n')
                {
                    needAdjust = true;
                    while (relatePos < str.Length)
                    {
                        if (!(str[relatePos] == '\r' || str[relatePos] == '\n'))
                        {
                            break;
                        }
                        relatePos++;
                    }
                }
            }

            int startToken = relatePos;

            if (startToken < str.Length)
            {

                if (!needAdjust)
                {
                    startToken = str.LastIndexOfAny(new char[] { ' ', '\r' }, relatePos);
                    if (startToken < 0) startToken = 0;
                }

                int endPos = str.IndexOfAny(new char[] { ' ', '\r' }, relatePos);
                if (endPos < 0) endPos = str.Length;

                logger.Debug("offset: {0} caret:{1} relpos: {2} startToken: {3} endToken: {4}", offset, caret, relatePos, startToken, endPos);

                string sentence = str.Substring(startToken, endPos - startToken);
                int cntLF = CountLineFeed(doc, offset, offset + startToken);
                int startHilight = offset + startToken - cntLF;

                return new DocumentSelection(sentence, startHilight, sentence.Length);
            }
            else //end of text
            {
                return new DocumentSelection("", 0, -1);
            }
        }

        public static DocumentSelection GetTextParagraph(Document doc)
        {
            Paragraph p = doc.GetParagraph(doc.CaretPosition);
            string str = doc.GetText(p.Range);
            int start = p.Range.Start.ToInt();

            DocumentSelection d = new DocumentSelection(str, start, p.Range.Length);
            d.CaretPosition = doc.CaretPosition.ToInt() - start;

            return d;
        }

        public static List<string> GetTextParagraphs(Document doc)
        {
            List<string> list = new List<string>();
            try
            {

                DocumentSelection d = new DocumentSelection();
                int pos = doc.CaretPosition.ToInt();
                while (list.Count < 3)
                {
                    Paragraph p = doc.GetParagraph(doc.CreatePosition(pos));
                    if (p.Range.End.ToInt() > pos)
                    {
                        list.Add(doc.GetText(p.Range));
                        pos = p.Range.End.ToInt() + 3;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                logger.Error(e);
            }

            return list;
        }

        public static void AddStringList(Document doc, List<string> sl)
        {
            doc.BeginUpdate();
            foreach (var s in sl)
            {
                Paragraph p = doc.AppendParagraph();
                ParagraphProperties paragraphProperties = doc.BeginUpdateParagraphs(p.Range);
                doc.AppendText(s);
                doc.EndUpdateParagraphs(paragraphProperties);
            }
            doc.EndUpdate();
            doc.Delete(doc.CreateRange(0, 1));
        }

        public static string GetText(Document doc, int start, int length)
        {
            DocumentPosition docStartPos = doc.CreatePosition(start);
            DocumentRange range = doc.CreateRange(docStartPos, length);
            return doc.GetText(range);
        }

        public static string GetSelectedText(Document doc)
        {
            return doc.GetText(doc.Selection);
        }

        public static void SetSpellHilight(Document doc, int start, int length, Color c, RichEditControl richEdit = null)
        {
            DocumentPosition docStartPos = doc.CreatePosition(start);
            DocumentRange range = doc.CreateRange(docStartPos, length);
            SetSpellHilight(doc, range, c, richEdit);
        }

        public static void SetSpellHilight(Document doc, DocumentRange range, Color c, RichEditControl richEdit = null)
        {
            if (richEdit != null)
            {
                richEdit.Invoke(new Func<object>(() =>
                {
                    string text = richEdit.Document.GetText(range);
                    text = text.Trim();
                    CharacterStyle style = richEdit.Document.CharacterStyles[text];

                    if (style == null)
                    {
                        style = richEdit.Document.CharacterStyles.CreateNew();
                    }
                    CharacterProperties cp = richEdit.Document.BeginUpdateCharacters(range);
                    if (cp != null)
                    {
                        try
                        {
                            style.AllCaps = cp.Style.AllCaps;
                            style.BackColor = cp.Style.BackColor;
                            style.Bold = cp.Style.Bold;
                            style.FontName = cp.Style.FontName;
                            style.FontSize = cp.Style.FontSize;
                            style.Hidden = cp.Style.Hidden;
                            style.Italic = cp.Style.Italic;
                            style.Strikeout = cp.Style.Strikeout;
                            style.Subscript = cp.Style.Subscript;
                            style.Superscript = cp.Style.Superscript;
                            style.Underline = cp.Style.Underline;
                            style.UnderlineColor = cp.Style.UnderlineColor;

                            richEdit.Document.CharacterStyles.Add(style);
                            style.BackColor = c;
                            style.Name = text;
                            cp.Style = style;
                            richEdit.Document.EndUpdateCharacters(cp);
                        }
                        catch (Exception exception)
                        {
                        }
                       
                    }
                    return null;
                }));
            }
            else
            {
                CharacterProperties cp = doc.BeginUpdateCharacters(range);
                cp.BackColor = c;
                doc.EndUpdateCharacters(cp);
            }
        }

        public static CharacterProperties GetCharProperties(Document doc, int startPos)
        {
            DocumentPosition docStartPos = doc.CreatePosition(startPos);
            DocumentRange range = doc.CreateRange(docStartPos, 1);
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            return cp;
        }

        public static CharacterProperties GetCaretPosCharProperties(Document doc)
        {
            DocumentPosition docStartPos = doc.CaretPosition;
            DocumentRange range = doc.CreateRange(docStartPos, 1);
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            doc.EndUpdateCharacters(cp);
            return cp;
        }

        public static bool IsMisSpelling(Document doc)
        {
            DocumentPosition docStartPos = doc.CaretPosition;
            DocumentRange range = doc.CreateRange(docStartPos, 1);
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            bool ret = cp.BackColor != Color.Transparent;
            doc.EndUpdateCharacters(cp);

            return ret;
        }

        public static void SetCaretPosition(Document doc, int position)
        {
            doc.CaretPosition = doc.CreatePosition(position);
        }

        public static void SetFontSize(Document doc, int start, int length, int size)
        {
            DocumentPosition docStartPos = doc.CreatePosition(start);
            DocumentRange range = doc.CreateRange(docStartPos, length);
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            cp.FontSize = size;
            doc.EndUpdateCharacters(cp);
        }

        public static void ResetTextHilight(Document doc, int start, int length)
        {
            if (start >= 0)
            {
                DocumentRange range = doc.CreateRange(start, length);
                doc.BeginUpdate();
                SetSpellHilight(doc, range, Color.Transparent);
                doc.EndUpdate();
            }
        }

        public static void DebugStat(Document doc)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Caret: {0}", doc.CaretPosition.ToInt()).AppendLine();
            if (doc.Selection.Length > 0)
            {
                sb.AppendFormat("Select: {0}-{1}-{2}[{3}]", doc.Selection.Start.ToInt(), doc.Selection.End.ToInt()
                    , doc.Selection.Length, doc.GetText(doc.Selection));
            }
            DocumentRange range0 = doc.CreateRange(doc.CreatePosition(0), doc.CaretPosition.ToInt());
            sb.AppendFormat("Str 0-{0} [{1}]", doc.CaretPosition.ToInt(), doc.GetText(range0)).AppendLine();
            DocumentRange range1 = doc.CreateRange(doc.CaretPosition.ToInt(), doc.Length - doc.CaretPosition.ToInt());
            sb.AppendFormat("Str {0}-{1}-{2} [{3}]", doc.CaretPosition.ToInt(), doc.Length, range1.Length, doc.GetText(range1));


            logger.Debug(sb.ToString());
        }

        public static void Replace(Document doc, int start, int len, string newText)
        {
            doc.BeginUpdate();
            DocumentRange range = doc.CreateRange(start, len);
            ResetTextHilight(doc, start, len);
            doc.Replace(range, newText);
            doc.EndUpdate();
        }

        public static int CountLineFeed(Document doc, int start, int end)
        {
            int ret = 0;
            if (end - start > 0)
            {
                DocumentRange range = doc.CreateRange(start, end - start);
                string str = doc.GetText(range);
                char[] arrs = str.ToCharArray();

                foreach (var c in arrs)
                {
                    if (c.Equals('\r'))
                    {
                        ret++;
                    }
                }
            }
            return ret;
        }
    }
}
