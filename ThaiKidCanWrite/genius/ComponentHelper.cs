using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LDWordProcessor.nectec;

namespace LDWordProcessor
{
    public class ComponentHelper
    {
        private static ComponentHelper instance;

        public static ComponentHelper Instance
        {
            get {

                if (instance == null) instance = new ComponentHelper();
                return ComponentHelper.instance;
            }
        }

        public static void VerifyInstalled()
        {
            try
            {
                Instance.VerifyVaja();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "แจ้งเตือน",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign,
                    true);
            }
        }

        private void VerifyVaja()
        {
            VajaTTS tts = new VajaTTS();
            if (!tts.IsVajaVoice())
            {
                throw new Exception("เครื่องคอมพิวเตอร์นี้ ไม่ได้ทำการติดตั้ง โปรแกรมอ่านออกเสียงภาษาไทย");
            }
        }
    }
}
