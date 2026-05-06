using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraRichEdit;
using System.Windows.Forms;
using NLog;

namespace LDWordProcessor
{
    public interface ILDUserTypeIdleListener
    {
        void OnUserTypeIdled();
    }

    public class LDUserTypeIdler
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Timer timer;
        private ILDUserTypeIdleListener listener;
        private int iLastInputTime = 0;
        private bool hasNewInput = false;

        public LDUserTypeIdler(RichEditControl editor)
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Enabled = true;
            editor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editor_KeyPress);
            timer.Tick += new System.EventHandler(this.timer_tick);
        }

        public void SetListener(ILDUserTypeIdleListener listener)
        {
            this.listener = listener;
        }

        public bool Enabled{
            get { return timer.Enabled; }
            set { timer.Enabled = value; }
        }

        private void editor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResetKeyIdle();
        }

        public void ResetKeyIdle()
        {
            iLastInputTime = Environment.TickCount;
            hasNewInput = true;
        }

        public bool IsKeyIdle()
        {
            int timeColaps = Environment.TickCount - iLastInputTime;
            bool ret = timeColaps > 500;
            return ret;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (listener != null)
            {
                if (hasNewInput)
                {
                    if (IsKeyIdle())
                    {
                        hasNewInput = false;
                        listener.OnUserTypeIdled();
                    }
                }
            }
        }
    }
}
