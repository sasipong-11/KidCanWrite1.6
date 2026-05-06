using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;

namespace LDWordProcessor.PInvoke
{
	/// <summary>
	/// Summary description for Win32.
	/// </summary>
	public class WinUser32
	{

	//===== user32.dll =====//

		[DllImport("User32.dll")]
		public static extern UInt32	FindWindow(string strClassName, string strWindowName);

		[DllImport("User32.dll")]
		public static extern UInt32	FindWindowEx(UInt32 hwndParent, UInt32 hwndChildAfter, string strClassName, string strWindowName);

		[DllImport("User32.dll")]
		public static extern int	GetClassName(UInt32 hwndParent, StringBuilder className, int nMaxCount);

		[DllImport("User32.dll")]
		public static extern UInt32	GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern UInt32	GetParent(UInt32 hWnd);

		[DllImport("User32.dll")]
		public static extern UInt32	GetWindow(UInt32 hwndParent, TypeGetWindow uCmd);

		[DllImport("user32.dll")]
		public static extern UInt32	GetWindowDC(UInt32 hWnd);

		[DllImport("user32.dll")] 
		public static extern UInt32	GetWindowLong(UInt32 hwnd, TypeGetWindowLong typeGetWindowLong) ;

		[DllImport("user32.dll")]
        public static extern bool GetWindowRect(UInt32 hWnd, out Rectangle lpRect);

		[DllImport("User32.Dll")]
		public static extern int	GetWindowText(UInt32 hwndParent, StringBuilder text, int nMaxCount);

		[DllImport("User32.Dll")]
		public static extern UInt32	GetWindowThreadProcessId( UInt32 hWnd, out UInt32 processId );

		[DllImport("user32.dll")]
		public static extern bool	InvalidateRect(UInt32 hwnd, ref Rectangle lpRect, bool bErase);

		[DllImport("user32.dll")]
		public static extern bool	IsRectEmpty([In] ref Rectangle lpRect);

		[DllImport("User32.dll")]
		public static extern bool	LockWorkStation();

		[DllImport("user32.dll")]
		public static extern bool	OffsetRect(ref Rectangle lprc, int dx, int dy);

		[DllImport("user32.dll")]
		public static extern int	ReleaseDC(UInt32 hWnd, UInt32 hDC);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern uint RegisterWindowMessage(string lpString);

		[DllImport("user32")] 
		public static extern int RegisterHotKey(UInt32 hwnd, int id, int typeHotkeyMod, int vk);

        [DllImport("User32.dll")]
        public static extern UInt32 SetForegroundWindow(UInt32 hWnd);

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(UInt32 hWnd, TypeGetSetWindowPos1 hWndInsertAfter, int X, int Y, int cx, int cy, TypeGetSetWindowPos2 uFlags);

		[DllImport("User32.dll")]
		public static extern UInt32	SendMessage(
			UInt32 hWnd,               // handle to destination window
			UInt32 Msg,                // message
			UInt32 wParam,             // first message parameter
			[MarshalAs(UnmanagedType.LPStr)] string lParam); // second message parameter

		[DllImport("User32.dll")]
		public static extern UInt32	SendMessage(
			UInt32 hWnd,               // handle to destination window
			UInt32 Msg,                // message
			UInt32 wParam,             // first message parameter
			UInt32 lParam);			// second message parameter

		[DllImport("User32.dll")]
		public static extern int	ShowWindow(UInt32 hwndParent, TypeShowWindow CmdShow );

		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(UInt32 hWnd, int id);

		[DllImport("user32.dll")]
		public static extern UInt32	WindowFromPoint(Point point);



		public WinUser32()
		{
		}

		~WinUser32()
		{
		}


	//----- Enumulate -----//

		public enum TypeGetWindow : int
		{
			GW_Child		= 5,
			GW_HWNDFIRST	= 0,
			GW_HWNDLAST		= 1,
			GW_HWNDNEXT		= 2,
			GW_HWNDPREV		= 3,
			GW_OWNER		= 4
		};

		public enum TypeHotkeyModify : int
		{
			MOD_ALT			= 0x1,
			MOD_CONTROL		= 0x2,
			MOD_SHIFT		= 0x4,
			MOD_WIN			= 0x8
		};

		public enum TypeShowWindow : int
		{
			SW_HIDE				= 0,
			SW_NORMAL			= 1,
			SW_SHOWMINIMIZED	= 2,
			SW_SHOWMAXIMIZED	= 3,
			SW_SHOWNOACTIVATE	= 4,
			SW_SHOW				= 5,
			SW_MINIMIZE			= 6,
			SW_SHOWMINNOACTIVE	= 7,
			SW_SHOWNA			= 8,
			SW_RESTORE			= 9,
			SW_SHOWDEFAULT		= 10
		};

		public enum TypeWindowStyles : uint
		{
			WS_OVERLAPPED       = 0x00000000,
			WS_POPUP			= 0x80000000,
			WS_CHILD			= 0x40000000,
			WS_MINIMIZE			= 0x20000000,
			WS_VISIBLE			= 0x10000000,
			WS_DISABLED			= 0x08000000,
			WS_CLIPSIBLINGS     = 0x04000000,
			WS_CLIPCHILDREN     = 0x02000000,
			WS_MAXIMIZE			= 0x01000000,
			WS_BORDER			= 0x00800000,
			WS_DLGFRAME			= 0x00400000,
			WS_VSCROLL			= 0x00200000,
			WS_HSCROLL			= 0x00100000,
			WS_SYSMENU			= 0x00080000,
			WS_THICKFRAME       = 0x00040000,
			WS_GROUP			= 0x00020000,
			WS_TABSTOP			= 0x00010000,

			WS_MINIMIZEBOX      = 0x00020000,
			WS_MAXIMIZEBOX      = 0x00010000,

			WS_CAPTION      = WS_BORDER | WS_DLGFRAME,
			WS_TILED        = WS_OVERLAPPED,
			WS_ICONIC       = WS_MINIMIZE,
			WS_SIZEBOX      = WS_THICKFRAME,
			WS_TILEDWINDOW      = WS_OVERLAPPEDWINDOW,

			WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,
			WS_POPUPWINDOW      = WS_POPUP | WS_BORDER | WS_SYSMENU,
			WS_CHILDWINDOW      = WS_CHILD
		}


		public enum TypeGetWindowLong : int
		{
			GWL_EXSTYLE		= -20,
			GWL_HINSTANCE	= -6,
			GWL_HWNDPARENT	= -8,
			GWL_ID			= -12,
			GWL_STYLE		= -16,
			GWL_USERDATA	= -21,
			GWL_WNDPROC		= -4,
			DWL_DLGPROC		= 4,
			DWL_MSGRESULT	= 0,
			DWL_USER		= 8
		}

        public enum TypeGetSetWindowPos1 : int
        {
         HWND_TOPMOST = -1,
         HWND_NOTOPMOST = -2,
         HWND_TOP =  0
        }

        public enum TypeGetSetWindowPos2 : uint
        {
         SWP_NOSIZE = 0x0001,
         SWP_NOMOVE = 0x0002,
         SWP_NOZORDER = 0x0004,
         SWP_NOREDRAW = 0x0008,
         SWP_NOACTIVATE = 0x0010,
         SWP_FRAMECHANGED = 0x0020,  /* The frame changed: send WM_NCCALCSIZE */
         SWP_SHOWWINDOW = 0x0040,
         SWP_HIDEWINDOW = 0x0080,
         SWP_NOCOPYBITS = 0x0100,
         SWP_NOOWNERZORDER = 0x0200,  /* Don't do owner Z ordering */
         SWP_NOSENDCHANGING = 0x0400, /* Don't send WM_WINDOWPOSCHANGING */
         TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE
        }
	}
}
