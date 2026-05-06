using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.Office.Utils;
using NLog;
using WordProcLD;
using System.Drawing;
using Microsoft.VisualBasic;
using api;
using LDWordProcessor.nectec;

#pragma warning disable 0414

namespace LDWordProcessor
{
    class LDAutoComplete
    {
        private static int MAX_TIME = 3;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private RichEditControl iRichEdit;
        ContextMenuStrip mnuContextMenu = new ContextMenuStrip();
        private bool enabled;
        private AutoCompleteLib ac = NectecAPI.Instance.AutoComplete;
        private SpellingLib spl = NectecAPI.Instance.Spelling;
        private PredictLib pd = NectecAPI.Instance.Predict;
        private Timer timer;
        private Timer popupTimer;
        private int iTimeCounter = MAX_TIME;
        private string iWordStart = "";
        private int Cf, Pf = 0;
        public event CompleteEventHandler Completed;
        public event PredictEventHandler Predicted;
        private ReaderComponent reader;
        public LDAutoComplete(RichEditControl richEdit)
        {
            iRichEdit = richEdit;
            mnuContextMenu.Font = new Font("AngsanaUPC", 18, FontStyle.Bold);
        }

        public bool Enabled
        {
            get { return enabled; }
            set { 
                enabled = value;
                if (enabled)
                {
                    timer = new Timer();
                    timer.Tick += new EventHandler(OnTimer_Tick); // Everytime timer ticks, timer_Tick will be called
                    timer.Interval = (1000) * (1);              // Timer will tick evert second    }

                    popupTimer = new Timer();
                    popupTimer.Tick += new EventHandler(OnPopupTimer_Tick); // Everytime timer ticks, timer_Tick will be called
                    popupTimer.Interval = 1000;              // Timer will tick evert second    }
                    mnuContextMenu.KeyPress += new KeyPressEventHandler(OnContextMenu_KeyPress);
                }
                else
                {
                    timer.Enabled = false;
                    popupTimer.Enabled = false;

                    timer = null;
                    popupTimer = null;
                }
            }
        }

        protected virtual void OnCompleted(string sWordStart, string sWordComplete)
        {
            if (Completed != null)
                Completed(sWordStart, sWordComplete);
        }

        protected virtual void OnPredicted(string sWordStart, string sWordPredict)
        {
            if (Predicted != null)
                Predicted(sWordStart, sWordPredict);
        }

        private Point GetLocalPoint()
        {
            DocumentPosition position = iRichEdit.Document.CaretPosition;
            Rectangle rect = iRichEdit.GetBoundsFromPosition(position);
            System.Drawing.Rectangle localRect = Units.DocumentsToPixels(rect, iRichEdit.DpiX, iRichEdit.DpiY);
            System.Drawing.Point localPoint = new System.Drawing.Point(localRect.Right, localRect.Bottom);

            return localPoint;
        }

        private void InsertText(string text)
        {
            if (text.Length > 0)
            {
                logger.Debug(text);
                DocumentPosition pos = iRichEdit.Document.CaretPosition;
                iRichEdit.Document.InsertText(pos, text);
            }
        }

        public void Show(string wComplete, int limit = 7)
        {
            //Initial Completion Flag
            Cf = 0; Pf = 0;

            LDWordSegment ws = new LDWordSegment();
            iWordStart = ws.GetLastThaiWord(wComplete);

            logger.Debug(iWordStart);
            List<string> acl = ac.AutoComplete(wComplete, limit);
            foreach (string str in acl)
            {
                logger.Debug("complete words - {0}", str);
            }

            //Prepare menu item
            mnuContextMenu.SuspendLayout();
            mnuContextMenu.Items.Clear();
            foreach (string str in acl)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(str);
                item.Click += new EventHandler(OnCompleteItemClick);
                item.MouseHover +=new EventHandler(OnMouseHover);
                mnuContextMenu.Items.Add(item);
            }
            mnuContextMenu.ResumeLayout();
            mnuContextMenu.Show(iRichEdit, GetLocalPoint());
            timer.Enabled = true;
        }

        private void OnCompleteItemClick(object sender, System.EventArgs e)
        {
            //Get text from user selected menu item
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            String str = m.Text;
            String sub_complete = str.Substring(iWordStart.Length);
            logger.Debug("User selected [{0}][{1}]", str.Length, str);
            //Adding UserDict to UserDict Temp Uni-gram (counter)

            ac.Update(iWordStart, str);

            OnCompleted(iWordStart, str);

            iWordStart = "";
            InsertText(sub_complete);
            Cf = 1;
            Pf = 0;

            //predict next word, delay for 1 sec
            iWordStart = str;
            popupTimer.Enabled = true;
        }

        private void OnMouseHover(object sender, System.EventArgs e)
        {
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            reader.Text = m.Text;
            reader.Play();
        }

        public void ShowPredictionPopup(String wPredict, int limit = 7)
        {
            List<string> pl = pd.Predict(wPredict, limit);

            //Prepare menu item
            mnuContextMenu.SuspendLayout();
            mnuContextMenu.Items.Clear();
            foreach (string str in pl)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(str);
                item.Click += new EventHandler(OnPredictItemClick);
                item.MouseHover += new EventHandler(OnMouseHover);
                mnuContextMenu.Items.Add(item);
            }
            mnuContextMenu.ResumeLayout();
            mnuContextMenu.Show(iRichEdit, GetLocalPoint());
            timer.Enabled = true;
        }

        private void OnPredictItemClick(object sender, System.EventArgs e)
        {
            Pf = 1;
            //Get text from user selected menu item
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            String predict = m.Text;
            logger.Debug("User selected [{0}][{1}]", predict.Length, predict);

            //Adding UserDict to UserDict Temp Bi-gram (counter and pairword)
            pd.Update(iWordStart, predict);

            OnPredicted(iWordStart, predict);
            InsertText(predict);
        }

        private void OnTimer_Tick(object sender, System.EventArgs e)
        {
            iTimeCounter--;
            if (iTimeCounter == 0)
            {
                CancelPopup();
                timer.Enabled = false;
            }
        }

        private void OnPopupTimer_Tick(object sender, System.EventArgs e)
        {
            ShowPredictionPopup(iWordStart);
            popupTimer.Enabled = false;
        }

        private void PerformContextMenuItem(List<string> sl, EventArgs b)
        {
            mnuContextMenu.SuspendLayout();
            mnuContextMenu.Items.Clear();
            foreach (string str in sl)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(str);
                item.Click += new EventHandler(OnCompleteItemClick);
                mnuContextMenu.Items.Add(item);
            }
            mnuContextMenu.ResumeLayout();
        }

        private void OnContextMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            CancelPopup();
            iRichEdit.Focus();
            SendKeys.Send(new String(e.KeyChar, 1));
        }

        public void CancelPopup()
        {
            mnuContextMenu.Hide();
            //SendKeys.Send("{ESC}");
        }

        public ReaderComponent Reader{
            get { return reader; }
            set { reader = value; }
        }
    }
}