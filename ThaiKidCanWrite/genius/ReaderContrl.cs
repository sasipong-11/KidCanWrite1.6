using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NLog;

namespace LDWordProcessor
{
 
    public partial class ReaderContrl : UserControl
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ReaderComponent reader { get; set; }
        private ReaderDisplayText displayText;

        public ReaderContrl()
        {
            InitializeComponent();
            displayText = new ReaderDisplayText(this);
        }


        private void RefreshText()
        {
            displayText.Refresh();
            lbText.Text = displayText.Text;
        }

        public void Play()
        {
            btnPlay.Enabled = false;
            btnStop.Enabled = true;
            reader.Play();
        }

        public void Stop()
        {
            reader.Stop();
        }

        public void SetText(string str, bool isParagraph)
        {
            memoInput.Text = str;
            if (isParagraph)
            {
                displayText.TextParagraph = str;
            }
            else
            {
                displayText.Text = str;
            }
            reader.Text = str;
        }

        public void OnWordChanged(string sWord, int iLength, int iPos)
        {
            displayText.OnWordChanged(iPos, iLength);
        }

        public void OnStopped()
        {
            btnPlay.Enabled = true;
            btnStop.Enabled = false;
            if ((bool) chkAutoClose.EditValue)
            {
                this.Hide();
            }
        }

        private void btnPlay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetText(memoInput.Text, true);
            Play();
        }

        private void btnStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stop();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stop();
            this.Hide();
        }

        private void btnIncFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            displayText.IncreaseFont();
            RefreshText();
        }

        private void btnDecFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            displayText.DecreaseFont();
            RefreshText();
        }
    }


}
