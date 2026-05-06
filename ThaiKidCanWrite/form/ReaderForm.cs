using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LDWordProcessor.nectec;
using NLog;
using DevExpress.XtraRichEdit.API.Native;
using System.Text.RegularExpressions;

#pragma warning disable 0169

namespace LDWordProcessor.form
{
    public partial class ReaderForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private RichEditHelper iRichHelper;
        private ReadTextType readTextType;
        private LDReaderPlayList iPlayList = new LDReaderPlayList();
        private bool forceStop = false;

        public ReaderForm()
        {
            InitializeComponent();
            iRichHelper = new RichEditHelper(richEdit);
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnPlay.Enabled = true;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            tkSpeed.EditValue = reader.Speed;
            tkVolume.EditValue = reader.Volume;
        }

        public bool HasData()
        {
            string s = richEdit.Text;
            return s.Length > 0;
        }

        private void btnPrev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            iPlayList.MovePrev();
            Play();
        }

        private void btnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            iPlayList.MoveNext();
            Play();
        }

        private void btnPlay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Play();
        }

        private void btnPause_ItemClick(object sender, ItemClickEventArgs e)
        {
            Pause();
        }

        private void btnStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stop();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stop();
            Close();
        }

        public void SetSettings(int speed, int volume)
        {
            reader.Speed = speed;
            reader.Volume = volume;
            tkSpeed.EditValue = speed;
            tkVolume.EditValue = volume;
        }

        public void SetRichText(string s)
        {
            readTextType = ReadTextType.ReadHere;
            richEdit.Text = s;
            richEdit.Document.CaretPosition = richEdit.Document.CreatePosition(0);
            CreateSentencePlayList();
            btnPrev.Visibility = BarItemVisibility.Never;
            btnNext.Visibility = BarItemVisibility.Never;
        }

        public void SetSentence(string s, int caretPos)
        {
            readTextType = ReadTextType.ReadSentence;
            richEdit.Text = s;
            richEdit.Document.CaretPosition = richEdit.Document.CreatePosition(caretPos);
            CreateSentencePlayList();
            btnPrev.Caption = "อ่านประโยคก่อนหน้า";
            btnNext.Caption = "อ่านประโยคถัดไป";
            btnPrev.Enabled = iPlayList.HasPrev();
            btnNext.Enabled = iPlayList.HasNext();
            btnPrev.Visibility = BarItemVisibility.Always;
            btnNext.Visibility = BarItemVisibility.Always;
        }

        private void CreateSentencePlayList()
        {
            int caretPos = richEdit.Document.CaretPosition.ToInt();
            iPlayList.Clear();

            //MatchCollection matches = Regex.Matches(richEdit.Text, @"\s", RegexOptions.Multiline);
            //foreach (System.Text.RegularExpressions.Match m in matches)
            //{
            //    logger.Debug("{0}-{1}", m.Value, m.Length);
            //}

            //LDUtils.printChars(richEdit.Text.ToArray());

            // Get a collection of matches.
            MatchCollection matches = Regex.Matches(richEdit.Text, @"\S+");

            // Use foreach loop.
            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                foreach (System.Text.RegularExpressions.Capture capture in match.Captures)
                {
                    logger.Debug("Index={0}, Value={1}", capture.Index, capture.Value);
                    int cntLF = DocumentHelper.CountLineFeed(richEdit.Document, 0, capture.Index);
                    LDReaderItem item = new LDReaderItem();
                    item.Start = capture.Index - cntLF;
                    item.Text = capture.Value;
                    item.End = capture.Index + capture.Length;
                    iPlayList.AddItem(item);

                }
            }
            int idx = iPlayList.FindCaretInItem(caretPos);
            iPlayList.MoveTo(idx);
        }

        public void SetTextList(List<string> sl)
        {
            readTextType = ReadTextType.ReadParagraph;
            richEdit.Text = "";
            DocumentHelper.AddStringList(richEdit.Document, sl);
            DocumentHelper.SetCaretPosition(richEdit.Document, 0);
            iPlayList.Clear();
            foreach (var s in sl)
            {
                iPlayList.AddString(s);
            }   
            iPlayList.MoveTo(0);
            btnPrev.Caption = "อ่านย่อหน้าก่อนหน้า";
            btnNext.Caption = "อ่านย่อหน้าถัดไป";
            btnPrev.Enabled = iPlayList.HasPrev();
            btnNext.Enabled = iPlayList.HasNext();
            btnPrev.Visibility = BarItemVisibility.Always;
            btnNext.Visibility = BarItemVisibility.Always;
        }

        public void Play()
        {
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnPlay.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnClose.Enabled = false;
            tkSpeed.Enabled = false;
            tkVolume.Enabled = false;
            forceStop = false;
            switch (readTextType)
            {
                case ReadTextType.ReadHere:
                    {
                        iRichHelper.Select(iPlayList.Current);
                        reader.Text = iPlayList.Current.Text;
                    }
                    break;
                default:
                    {
                        iRichHelper.Select(iPlayList.Current);
                        reader.Text = iPlayList.Current.Text;
                    }
                    break;
            }

            reader.Play();
        }

        private void Pause()
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnPlay.Enabled = true;
            btnClose.Enabled = true;
            reader.Pause();
        }

        private void Stop()
        {
            forceStop = true;
            reader.Stop();
        }

        private void reader_Stopped(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnPrev.Enabled = iPlayList.HasPrev();
            btnNext.Enabled = iPlayList.HasNext();
            btnPlay.Enabled = true;
            tkSpeed.Enabled = true;
            btnClose.Enabled = true;
            tkVolume.Enabled = true;

            switch (readTextType)
            {
                case ReadTextType.ReadHere:
                    if (!forceStop)
                    {
                        if (iPlayList.MoveNext())
                        {
                            Play();
                        }
                    }
                    break;
            }
        }

        private void reader_WordChanged(string sWord, int iLength, int iPos)
        {
            int start = iPos;
            int cntLF = DocumentHelper.CountLineFeed(richEdit.Document, 0, start);
            switch (readTextType)
            {
                case ReadTextType.ReadHere:
                case ReadTextType.ReadParagraph:
                case ReadTextType.ReadSentence:
                    start += iPlayList.Current.Start;
                    break;
            }

            start -= cntLF;

            iRichHelper.SelectLD(start, iLength);
            logger.Debug("{0}[{1}][{2}]", sWord, start, iLength);
        }

        private void tkSpeed_EditValueChanged(object sender, EventArgs e)
        {
            reader.Speed = (int) tkSpeed.EditValue;
        }

        private void tkVolume_EditValueChanged(object sender, EventArgs e)
        {
            reader.Volume = (int) tkVolume.EditValue;
        }

        private void btnFont1_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocumentHelper.SetFontSize(richEdit.Document, 0, richEdit.Text.Length, 16);
        }

        private void btnFont2_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocumentHelper.SetFontSize(richEdit.Document, 0, richEdit.Text.Length, 24);
        }

        private void btnFont3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocumentHelper.SetFontSize(richEdit.Document, 0, richEdit.Text.Length, 32);
        }
    }

    class LDReaderPlayList 
   // partial class LDReaderPlayList : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private List<LDReaderItem> list;
        public int curPos;
        private int cursorPosition;
        private int totalLength;
        private ReadTextType readTextType;
        public LDReaderPlayList()
        {
            list = new List<LDReaderItem>();
            Clear();
        }

        public LDReaderItem Current
        {
            get
            {
                return list[curPos];
            }
        }

        public bool HasNext()
        {
            return curPos < list.Count - 1;
        }

        public bool HasPrev()
        {
            return curPos > 0;
        }

        public bool MoveNext()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                curPos++;
            }
            return canMove;
        }

        public bool MovePrev()
        {
            bool canMove = HasPrev();
            if (canMove)
            {
                curPos--;
            }
            return canMove;
        }

        public void Reset()
        {
            curPos = -1;
            cursorPosition = 0;
            totalLength = 0;
        }

        public void AddString(string str)
        {
           // richEdit.Text = str;
            totalLength += str.Length;

            if (str.Length > 0)
            {
                LDReaderItem item = new LDReaderItem();
                item.Start = cursorPosition;
                item.Text = str;
                item.End = cursorPosition + str.Length;
                cursorPosition = item.End + 1;
                list.Add(item);
            }
        }

        public void AddItem(LDReaderItem item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            Reset();
            list.Clear();
        }

        public void MoveTo(int idx)
        {
            curPos = idx;
        }

        public LDReaderItem GetItem(int idx)
        {
            return list[idx];
        }

        public int FindCaretInItem(int caretPos)
        {
            logger.Debug("caretPos={0}", caretPos);
            for(int i=0;i<list.Count;i++){
                LDReaderItem item = list[i];
                logger.Debug("{3} = {0},{1},{2}", item.Start, item.End, item.Text, i);
                if(item.IsCaretInside(caretPos)){
                    return i;
                }
            }
            return 0;
        }

       

    }
}
