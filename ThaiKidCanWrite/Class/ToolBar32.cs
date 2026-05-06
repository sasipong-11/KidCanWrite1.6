using System;
using System.Linq;
using System.Collections;
using System.Drawing;
using System.Diagnostics;
namespace  TaskBar32
{
	/// <summary>
	/// Summary description for ToolBar32.
	/// </summary>
	public class ToolBar32
	{
        //private UInt32 _hndToolbar32 = 0;
        private UInt32[] _appDesk0 = new UInt32[1];
        public UInt32 hWordSpellID = 0;
        public UInt32 id = 0;
        public string HProgram;
        bool setForm = false;
        
        public ToolBar32()
        {

        }
		
        public ToolBar32(string str)
		{
            HProgram = str;
		}

        public void GetNextProcessID()
        {
            UInt32[] proc = new UInt32[100];
            int count = 0;
            
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        proc[count] = (uint)p.MainWindowHandle;
                        count++;
                    }
                }
                catch { }
            }

            hWordSpellID = PInvoke.WinUser32.FindWindow(null, HProgram);
            id = hWordSpellID;
            int xxs;
            do
            {
                id = PInvoke.WinUser32.GetWindow(id, PInvoke.WinUser32.TypeGetWindow.GW_HWNDNEXT);
                xxs = ((from e2 in proc
                        where e2.Equals(id)
                        select e2).Count());
                if (hWordSpellID == id) break;
            } while (xxs == 0);

            PInvoke.WinUser32.SetForegroundWindow(id);
        }

        public void SetWindows()
        {
            GetNextProcessID();
            Rectangle rct;
            UInt32 desktop = PInvoke.WinUser32.GetDesktopWindow();
            if (!PInvoke.WinUser32.GetWindowRect(desktop, out rct))
            {
                //MessageBox.Show("ERROR");
            }
            else
            {
                // Width = 260, Height = 495  255, 495
                if (setForm)
                {
                    PInvoke.WinUser32.SetWindowPos(id, PInvoke.WinUser32.TypeGetSetWindowPos1.HWND_NOTOPMOST, 0, 0, (rct.Right - rct.Left), (rct.Bottom - rct.Top) - 25, PInvoke.WinUser32.TypeGetSetWindowPos2.SWP_SHOWWINDOW);
                    PInvoke.WinUser32.SetWindowPos(hWordSpellID, PInvoke.WinUser32.TypeGetSetWindowPos1.HWND_TOP, (rct.Right - rct.Left) - 255, 0, 255, 495, PInvoke.WinUser32.TypeGetSetWindowPos2.SWP_SHOWWINDOW);
                    setForm = false;
                }
                else
                {
                    PInvoke.WinUser32.SetWindowPos(id, PInvoke.WinUser32.TypeGetSetWindowPos1.HWND_NOTOPMOST, 0, 0, (rct.Right - rct.Left) - 255, (rct.Bottom - rct.Top) - 25, PInvoke.WinUser32.TypeGetSetWindowPos2.SWP_SHOWWINDOW);
                    PInvoke.WinUser32.SetWindowPos(hWordSpellID, PInvoke.WinUser32.TypeGetSetWindowPos1.HWND_TOP, (rct.Right - rct.Left) - 255, 0, 255, 495, PInvoke.WinUser32.TypeGetSetWindowPos2.SWP_SHOWWINDOW);
                    setForm = true;
                }
                PInvoke.WinUser32.SetForegroundWindow(id);
            }
        }

        public void SetWindowsStart()
        {
            Rectangle rct;
            UInt32 desktop = PInvoke.WinUser32.GetDesktopWindow();
            if (!PInvoke.WinUser32.GetWindowRect(desktop, out rct))
            {
                //MessageBox.Show("ERROR");
            }
            else
            {
                    hWordSpellID = PInvoke.WinUser32.FindWindow(null, HProgram);  
                    PInvoke.WinUser32.SetWindowPos(hWordSpellID, PInvoke.WinUser32.TypeGetSetWindowPos1.HWND_TOP, (rct.Right - rct.Left) - 255, 0, 255, 495, PInvoke.WinUser32.TypeGetSetWindowPos2.SWP_SHOWWINDOW);
            }
        }
	}
}
