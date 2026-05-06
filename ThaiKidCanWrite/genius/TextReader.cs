using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

#pragma warning disable 0169
#pragma warning disable 0414
#pragma warning disable 0649

namespace LDWordProcessor
{
    class TextReader
    {
        private ReaderComponent reader = new ReaderComponent();
        private form.LDReaderPlayList readerPlaylist = new form.LDReaderPlayList();
        private form.ReaderForm readList = new form.ReaderForm();
        private RichEditHelper iRichHelper;
        private int LDCursorPosition;
        private int LDCursorPositionRelate;
        private int LDCursorParagraphStart;
        public int startPosition;
        private bool noSelection;
        private bool readInPane;
        public int memoSkipCount;
        public DevExpress.XtraEditors.MemoEdit memoEdit;
        private DocumentSelection docSelection = new DocumentSelection();

        public event EventHandler Stopped;
        public event EventHandler Started;


        public int Volume
        {
            get { return reader.Volume; }
            set { reader.Volume = value; }
        }

        public int Speed
        {
            get { return reader.Speed; }
            set { reader.Speed = value; }
        }

        public TextReader(RichEditHelper clientRichEditHelper)
        {
            reader.WordChanged += new nectec.TTSWordChangeEventHandler(reader_WordChanged);
            reader.Stopped += new EventHandler(reader_Stopped);
            setRichEditHelper(clientRichEditHelper);
            LDCursorPosition = iRichHelper.RictEditControl.Document.CaretPosition.ToInt();
            LDCursorPositionRelate = LDCursorPosition - iRichHelper.RictEditControl.Document.Range.Start.ToInt();
            LDCursorParagraphStart = iRichHelper.RictEditControl.Document.GetParagraph(iRichHelper.RictEditControl.Document.CreatePosition(LDCursorPosition)).Range.Start.ToInt();
            startPosition = LDCursorPositionRelate;
        }

        public void setRichEditHelper(RichEditHelper clientRichHelper)
        {
            iRichHelper = clientRichHelper;
           
        }

        void reader_WordChanged(string sWord, int iLength, int iPos)
        {
            if (noSelection)
                return;

            if (readInPane)
            {
                string text = memoEdit.Text;
                text = text.Insert(iPos + memoSkipCount + iLength, " ");
                memoEdit.Text = text;
                memoEdit.Select(iPos + memoSkipCount, iLength);
                memoSkipCount++;
                memoEdit.ScrollToCaret();
            }
            else
            {
                int start = startPosition;
                start += iPos;

                //if (readerPlaylist.ToString() != "")
                //{
                //    start += readerPlaylist.Current.Start;
                //}
                int cntLF = DocumentHelper.CountLineFeed(iRichHelper.RictEditControl.Document, startPosition, start);
                start -= cntLF;
                iRichHelper.SelectLD(start, iLength);
                //throw new NotImplementedException();
            }
        }

        void reader_Stopped(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //Stopped(sender, e);
        }


        public void ReadText(List<string> strTextList)
        {
            readInPane = false;
            startPosition = LDCursorParagraphStart;
            readerPlaylist.Clear();
            foreach (var s in strTextList)
            {
                readerPlaylist.AddString(s);
                readerPlaylist.MoveTo(0);
            }

            reader.Text = readerPlaylist.Current.Text;
            noSelection = false;
            reader.Play();
        }


        public void ReadTextNext(/*List<string> strTextList,*/ref form.LDReaderPlayList readPlaylist)
        {
            
          //  readerPlaylist = readPlaylist;
          //  readerPlaylist.MoveNext();
          //  reader.Play();
            /*if (readerPlaylist.curPos < 0)
            {

                startPosition = LDCursorParagraphStart;
                readerPlaylist.Clear();
                foreach (var s in strTextList)
                {
                    readerPlaylist.AddString(s);
                    readerPlaylist.MoveTo(0);
                }

                reader.Text = readerPlaylist.Current.Text;
                noSelection = false;
              //  reader.Play();

            }
            else {

                reader.Text = readerPlaylist.Current.Text;
                noSelection = false;
               // reader.Play();
            }
           // readerPlaylist.MoveNext();
           // reader.Play();*/
        }

        public void ReadTextPrev()
        {
            readerPlaylist.MovePrev();
            reader.Play();
        }

        public void ReadText(string strText)
        {
            readInPane = false;
            startPosition = iRichHelper.RictEditControl.Document.Selection.Start.ToInt();
            reader.Text = strText;
            noSelection = false;
            reader.Play();
        }

        public void ReadTextInPane(string strText)
        {
            readInPane = true;
            reader.Text = strText;
            noSelection = false;
            reader.Play();
        }

        public void ReadTextSentence(string strText)
        {
            //startPosition has been assigned through caller
            readInPane = false;
            reader.Text = strText;
            noSelection = false;
            reader.Play();
        }

        public void ReadAllText(string strText)
        {
            readInPane = false;
            startPosition = LDCursorPosition;
            //Console.WriteLine("cursor-->" + LDCursorPosition);
            reader.Text = strText;
            //Console.WriteLine("line-->"+strText);
            noSelection = false;
            reader.Play();

           // reader.Stop();

        }

        public void ReadAllTextNoSelect(string strText)
        {
            readInPane = false;
            startPosition = LDCursorPosition;
            reader.Text = strText;
            noSelection = true;
            reader.Play();
        }

        public void Play()
        {
        }

        public void Stop()
        {
            if (reader.IsPlaying)
                reader.Pause();
            else
                reader.Play();
        }
        public void next()
        { 
            readerPlaylist.MoveNext();
             reader.Play();
             
        }
        public void prev()
        {
            readerPlaylist.MovePrev();
            reader.Play();
           // reader.Pause();
        
        }


      
    }
}
