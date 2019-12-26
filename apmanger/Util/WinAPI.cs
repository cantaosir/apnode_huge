using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Util
{
    public static class WinAPI
    {
        public const uint ACCESS_SYSTEM_SECURITY = 0x1000000;
        public const int AW_ACTIVATE = 0x20000;
        public const int AW_BLEND = 0x80000;
        public const int AW_CENTER = 0x10;
        public const int AW_HIDE = 0x10000;
        public const int AW_HOR_NEGATIVE = 2;
        public const int AW_HOR_POSITIVE = 1;
        public const int AW_SLIDE = 0x40000;
        public const int AW_VER_NEGATIVE = 8;
        public const int AW_VER_POSITIVE = 4;
        public const uint BLACKNESS = 0x42;
        public const int CREATE_ALWAYS = 2;
        public const int CREATE_DEFAULT_ERROR_MODE = 0x4000000;
        public const int CREATE_FORCEDOS = 0x2000;
        public const int CREATE_NEW = 1;
        public const int CREATE_NEW_CONSOLE = 0x10;
        public const int CREATE_NEW_PROCESS_GROUP = 0x200;
        public const int CREATE_NO_WINDOW = 0x8000000;
        public const int CREATE_SEPARATE_WOW_VDM = 0x800;
        public const int CREATE_SHARED_WOW_VDM = 0x1000;
        public const int CREATE_SUSPENDED = 4;
        public const int CREATE_UNICODE_ENVIRONMENT = 0x400;
        public const int CS_BYTEALIGNCLIENT = 0x1000;
        public const int CS_BYTEALIGNWINDOW = 0x2000;
        public const int CS_CLASSDC = 0x40;
        public const int CS_DBLCLKS = 8;
        public const int CS_DROPSHADOW = 0x20000;
        public const int CS_GLOBALCLASS = 0x4000;
        public const int CS_HREDRAW = 2;
        public const int CS_IME = 0x10000;
        public const int CS_KEYCVTWINDOW = 4;
        public const int CS_NOCLOSE = 0x200;
        public const int CS_NOKEYCVT = 0x100;
        public const int CS_OWNDC = 0x20;
        public const int CS_PARENTDC = 0x80;
        public const int CS_SAVEBITS = 0x800;
        public const int CS_VREDRAW = 1;
        public const int DDD_EXACT_MATCH_ON_REMOVE = 4;
        public const int DDD_NO_BROADCAST_SYSTEM = 8;
        public const int DDD_RAW_TARGET_PATH = 1;
        public const int DDD_REMOVE_DEFINITION = 2;
        public const int DEBUG_ONLY_THIS_PROCESS = 2;
        public const int DEBUG_PROCESS = 1;
        public const int DETACHED_PROCESS = 8;
        public const uint DSTINVERT = 0x550009;
        public const int FILE_ACTION_ADDED = 1;
        public const int FILE_ACTION_MODIFIED = 3;
        public const int FILE_ACTION_REMOVED = 2;
        public const int FILE_ACTION_RENAMED_NEW_NAME = 5;
        public const int FILE_ACTION_RENAMED_OLD_NAME = 4;
        public const int FILE_ATTRIBUTE_ARCHIVE = 0x20;
        public const int FILE_ATTRIBUTE_COMPRESSED = 0x800;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x10;
        public const int FILE_ATTRIBUTE_HIDDEN = 2;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        public const int FILE_ATTRIBUTE_OFFLINE = 0x1000;
        public const int FILE_ATTRIBUTE_READONLY = 1;
        public const int FILE_ATTRIBUTE_SYSTEM = 4;
        public const int FILE_ATTRIBUTE_TEMPORARY = 0x100;
        public const int FILE_CASE_PRESERVED_NAMES = 2;
        public const int FILE_CASE_SENSITIVE_SEARCH = 1;
        public const int FILE_FILE_COMPRESSION = 0x10;
        public const int FILE_FLAG_BACKUP_SEMANTICS = 0x2000000;
        public const int FILE_FLAG_DELETE_ON_CLOSE = 0x4000000;
        public const int FILE_FLAG_NO_BUFFERING = 0x20000000;
        public const int FILE_FLAG_OVERLAPPED = 0x40000000;
        public const int FILE_FLAG_POSIX_SEMANTICS = 0x1000000;
        public const int FILE_FLAG_RANDOM_ACCESS = 0x10000000;
        public const int FILE_FLAG_SEQUENTIAL_SCAN = 0x8000000;
        public const int FILE_NOTIFY_CHANGE_ATTRIBUTES = 4;
        public const int FILE_NOTIFY_CHANGE_CREATION = 0x40;
        public const int FILE_NOTIFY_CHANGE_DIR_NAME = 2;
        public const int FILE_NOTIFY_CHANGE_FILE_NAME = 1;
        public const int FILE_NOTIFY_CHANGE_LAST_ACCESS = 0x20;
        public const int FILE_NOTIFY_CHANGE_LAST_WRITE = 0x10;
        public const int FILE_NOTIFY_CHANGE_SECURITY = 0x100;
        public const int FILE_NOTIFY_CHANGE_SIZE = 8;
        public const int FILE_PERSISTENT_ACLS = 8;
        public const int FILE_SHARE_DELETE = 4;
        public const int FILE_SHARE_READ = 1;
        public const int FILE_SHARE_WRITE = 2;
        public const int FILE_UNICODE_ON_DISK = 4;
        public const int FILE_VOLUME_IS_COMPRESSED = 0x8000;
        public const int GCL_CBCLSEXTRA = -20;
        public const int GCL_CBWNDEXTRA = -18;
        public const int GCL_HBRBACKGROUND = -10;
        public const int GCL_HCURSOR = -12;
        public const int GCL_HICON = -14;
        public const int GCL_HICONSM = -34;
        public const int GCL_HMODULE = -16;
        public const int GCL_MENUNAME = -8;
        public const int GCL_STYLE = -26;
        public const int GCL_WNDPROC = -24;
        public const int GCW_ATOM = -32;
        public const uint GENERIC_ALL = 0x10000000;
        public const uint GENERIC_EXECUTE = 0x20000000;
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const int GWL_EXSTYLE = -20;
        public const int GWL_HINSTANCE = -6;
        public const int GWL_HWNDPARENT = -8;
        public const int GWL_ID = -12;
        public const int GWL_STYLE = -16;
        public const int GWL_USERDATA = -21;
        public const int GWL_WNDPROC = -4;
        public const int HIGH_PRIORITY_CLASS = 0x80;
        public const int HTBORDER = 0x12;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 0x10;
        public const int HTBOTTOMRIGHT = 0x11;
        public const int HTCAPTION = 2;
        public const int HTCLIENT = 1;
        public const int HTCLOSE = 20;
        public const int HTERROR = -2;
        public const int HTGROWBOX = 4;
        public const int HTHELP = 0x15;
        public const int HTHSCROLL = 6;
        public const int HTLEFT = 10;
        public const int HTMAXBUTTON = 9;
        public const int HTMENU = 5;
        public const int HTMINBUTTON = 8;
        public const int HTNOWHERE = 0;
        public const int HTOBJECT = 0x13;
        public const int HTREDUCE = 8;
        public const int HTRIGHT = 11;
        public const int HTSIZE = 4;
        public const int HTSIZEFIRST = 10;
        public const int HTSIZELAST = 0x11;
        public const int HTSYSMENU = 3;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTTRANSPARENT = -1;
        public const int HTVSCROLL = 7;
        public const int HTZOOM = 9;
        public static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        public static readonly IntPtr HWND_TOP = new IntPtr(0);
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        public const int IDLE_PRIORITY_CLASS = 0x40;
        public const int INVALID_HANDLE_VALUE = -1;
        public const int LWA_ALPHA = 2;
        public const int LWA_COLORKEY = 1;
        public const int MAILSLOT_NO_MESSAGE = -1;
        public const int MAILSLOT_WAIT_FOREVER = -1;
        public const uint MAXIMUM_ALLOWED = 0x2000000;
        public const uint MERGECOPY = 0xc000ca;
        public const uint MERGEPAINT = 0xbb0226;
        public const int NORMAL_PRIORITY_CLASS = 0x20;
        public const uint NOTSRCCOPY = 0x330008;
        public const uint NOTSRCERASE = 0x1100a6;
        public const int OPEN_ALWAYS = 4;
        public const int OPEN_EXISTING = 3;
        public const uint PATCOPY = 0xf00021;
        public const uint PATINVERT = 0x5a0049;
        public const uint PATPAINT = 0xfb0a09;
        public const int PROFILE_KERNEL = 0x20000000;
        public const int PROFILE_SERVER = 0x40000000;
        public const int PROFILE_USER = 0x10000000;
        public const uint READ_CONTROL = 0x20000;
        public const int REALTIME_PRIORITY_CLASS = 0x100;
        public const int SB_BOTH = 3;
        public const int SB_CTL = 2;
        public const int SB_HORZ = 0;
        public const int SB_VERT = 1;
        public const int SM_ARRANGE = 0x38;
        public const int SM_CLEANBOOT = 0x43;
        public const int SM_CMETRICS = 0x4c;
        public const int SM_CMONITORS = 80;
        public const int SM_CMOUSEBUTTONS = 0x2b;
        public const int SM_CXBORDER = 5;
        public const int SM_CXCURSOR = 13;
        public const int SM_CXDLGFRAME = 7;
        public const int SM_CXDOUBLECLK = 0x24;
        public const int SM_CXDRAG = 0x44;
        public const int SM_CXEDGE = 0x2d;
        public const int SM_CXFIXEDFRAME = 7;
        public const int SM_CXFOCUSBORDER = 0x53;
        public const int SM_CXFRAME = 0x20;
        public const int SM_CXFULLSCREEN = 0x10;
        public const int SM_CXHSCROLL = 0x15;
        public const int SM_CXHTHUMB = 10;
        public const int SM_CXICON = 11;
        public const int SM_CXICONSPACING = 0x26;
        public const int SM_CXMAXIMIZED = 0x3d;
        public const int SM_CXMAXTRACK = 0x3b;
        public const int SM_CXMENUCHECK = 0x47;
        public const int SM_CXMENUSIZE = 0x36;
        public const int SM_CXMIN = 0x1c;
        public const int SM_CXMINIMIZED = 0x39;
        public const int SM_CXMINSPACING = 0x2f;
        public const int SM_CXMINTRACK = 0x22;
        public const int SM_CXSCREEN = 0;
        public const int SM_CXSIZE = 30;
        public const int SM_CXSIZEFRAME = 0x20;
        public const int SM_CXSMICON = 0x31;
        public const int SM_CXSMSIZE = 0x34;
        public const int SM_CXVIRTUALSCREEN = 0x4e;
        public const int SM_CXVSCROLL = 2;
        public const int SM_CYBORDER = 6;
        public const int SM_CYCAPTION = 4;
        public const int SM_CYCURSOR = 14;
        public const int SM_CYDLGFRAME = 8;
        public const int SM_CYDOUBLECLK = 0x25;
        public const int SM_CYDRAG = 0x45;
        public const int SM_CYEDGE = 0x2e;
        public const int SM_CYFIXEDFRAME = 8;
        public const int SM_CYFOCUSBORDER = 0x54;
        public const int SM_CYFRAME = 0x21;
        public const int SM_CYFULLSCREEN = 0x11;
        public const int SM_CYHSCROLL = 3;
        public const int SM_CYICON = 12;
        public const int SM_CYICONSPACING = 0x27;
        public const int SM_CYKANJIWINDOW = 0x12;
        public const int SM_CYMAXIMIZED = 0x3e;
        public const int SM_CYMAXTRACK = 60;
        public const int SM_CYMENU = 15;
        public const int SM_CYMENUCHECK = 0x48;
        public const int SM_CYMENUSIZE = 0x37;
        public const int SM_CYMIN = 0x1d;
        public const int SM_CYMINIMIZED = 0x3a;
        public const int SM_CYMINSPACING = 0x30;
        public const int SM_CYMINTRACK = 0x23;
        public const int SM_CYSCREEN = 1;
        public const int SM_CYSIZE = 0x1f;
        public const int SM_CYSIZEFRAME = 0x21;
        public const int SM_CYSMCAPTION = 0x33;
        public const int SM_CYSMICON = 50;
        public const int SM_CYSMSIZE = 0x35;
        public const int SM_CYVIRTUALSCREEN = 0x4f;
        public const int SM_CYVSCROLL = 20;
        public const int SM_CYVTHUMB = 9;
        public const int SM_DBCSENABLED = 0x2a;
        public const int SM_DEBUG = 0x16;
        public const int SM_IMMENABLED = 0x52;
        public const int SM_MENUDROPALIGNMENT = 40;
        public const int SM_MIDEASTENABLED = 0x4a;
        public const int SM_MOUSEPRESENT = 0x13;
        public const int SM_MOUSEWHEELPRESENT = 0x4b;
        public const int SM_NETWORK = 0x3f;
        public const int SM_PENWINDOWS = 0x29;
        public const int SM_RESERVED1 = 0x18;
        public const int SM_RESERVED2 = 0x19;
        public const int SM_RESERVED3 = 0x1a;
        public const int SM_RESERVED4 = 0x1b;
        public const int SM_SAMEDISPLAYFORMAT = 0x51;
        public const int SM_SECURE = 0x2c;
        public const int SM_SHOWSOUNDS = 70;
        public const int SM_SLOWMACHINE = 0x49;
        public const int SM_SWAPBUTTON = 0x17;
        public const int SM_XVIRTUALSCREEN = 0x4c;
        public const int SM_YVIRTUALSCREEN = 0x4d;
        public const uint SPECIFIC_RIGHTS_ALL = 0xffff;
        public const uint SRCAND = 0x8800c6;
        public const uint SRCCOPY = 0xcc0020;
        public const uint SRCERASE = 0x440328;
        public const uint SRCINVERT = 0x660046;
        public const uint SRCPAINT = 0xee0086;
        public const uint STANDARD_RIGHTS_ALL = 0x1f0000;
        public const uint STANDARD_RIGHTS_EXECUTE = 0x20000;
        public const uint STANDARD_RIGHTS_READ = 0x20000;
        public const uint STANDARD_RIGHTS_WRITE = 0x20000;
        public const int STARTF_FORCEOFFFEEDBACK = 0x80;
        public const int STARTF_FORCEONFEEDBACK = 0x40;
        public const int STARTF_RUNFULLSCREEN = 0x20;
        public const int STARTF_USECOUNTCHARS = 8;
        public const int STARTF_USEFILLATTRIBUTE = 0x10;
        public const int STARTF_USEHOTKEY = 0x200;
        public const int STARTF_USEPOSITION = 4;
        public const int STARTF_USESHOWWINDOW = 1;
        public const int STARTF_USESIZE = 2;
        public const int STARTF_USESTDHANDLES = 0x100;
        public const short SW_FORCEMINIMIZE = 11;
        public const short SW_HIDE = 0;
        public const short SW_MAX = 11;
        public const short SW_MAXIMIZE = 3;
        public const short SW_MINIMIZE = 6;
        public const short SW_NORMAL = 1;
        public const short SW_RESTORE = 9;
        public const short SW_SHOW = 5;
        public const short SW_SHOWDEFAULT = 10;
        public const short SW_SHOWMAXIMIZED = 3;
        public const short SW_SHOWMINIMIZED = 2;
        public const short SW_SHOWMINNOACTIVE = 7;
        public const short SW_SHOWNA = 8;
        public const short SW_SHOWNOACTIVATE = 4;
        public const short SW_SHOWNORMAL = 1;
        public const uint SWP_ASYNCWINDOWPOS = 0x4000;
        public const uint SWP_DEFERERASE = 0x2000;
        public const uint SWP_DRAWFRAME = 0x20;
        public const uint SWP_FRAMECHANGED = 0x20;
        public const uint SWP_HIDEWINDOW = 0x80;
        public const uint SWP_NOACTIVATE = 0x10;
        public const uint SWP_NOCOPYBITS = 0x100;
        public const uint SWP_NOMOVE = 2;
        public const uint SWP_NOOWNERZORDER = 0x200;
        public const uint SWP_NOREDRAW = 8;
        public const uint SWP_NOREPOSITION = 0x200;
        public const uint SWP_NOSENDCHANGING = 0x400;
        public const uint SWP_NOSIZE = 1;
        public const uint SWP_NOZORDER = 4;
        public const uint SWP_SHOWWINDOW = 0x40;
        public const int TRUNCATE_EXISTING = 5;
        public const int ULW_ALPHA = 2;
        public const int ULW_COLORKEY = 1;
        public const int ULW_OPAQUE = 4;
        public const uint WAIT_ABANDONED = 0x80;
        public const uint WAIT_FAILED = uint.MaxValue;
        public const uint WAIT_OBJECT_0 = 0;
        public const uint WAIT_TIMEOUT = 0x102;
        public const int WH_CALLWNDPROC = 4;
        public const int WH_CALLWNDPROCRET = 12;
        public const int WH_CBT = 5;
        public const int WH_DEBUG = 9;
        public const int WH_FOREGROUNDIDLE = 11;
        public const int WH_GETMESSAGE = 3;
        public const int WH_HARDWARE = 8;
        public const int WH_JOURNALPLAYBACK = 1;
        public const int WH_JOURNALRECORD = 0;
        public const int WH_KEYBOARD = 2;
        public const int WH_KEYBOARD_LL = 13;
        public const int WH_MOUSE = 7;
        public const int WH_MOUSE_LL = 14;
        public const int WH_SHELL = 10;
        public const int WH_SYSMSGFILTER = 6;
        public const uint WHITENESS = 0xff0062;
        public const int WM_ACTIVATE = 6;
        public const int WM_ACTIVATEAPP = 0x1c;
        public const int WM_AFXFIRST = 0x360;
        public const int WM_AFXLAST = 0x37f;
        public const int WM_APP = 0x8000;
        public const int WM_ASKCBFORMATNAME = 780;
        public const int WM_CANCELJOURNAL = 0x4b;
        public const int WM_CANCELMODE = 0x1f;
        public const int WM_CAPTURECHANGED = 0x215;
        public const int WM_CHANGECBCHAIN = 0x30d;
        public const int WM_CHAR = 0x102;
        public const int WM_CHARTOITEM = 0x2f;
        public const int WM_CHILDACTIVATE = 0x22;
        public const int WM_CLEAR = 0x303;
        public const int WM_CLOSE = 0x10;
        public const int WM_COMMAND = 0x111;
        public const int WM_COMMNOTIFY = 0x44;
        public const int WM_COMPACTING = 0x41;
        public const int WM_COMPAREITEM = 0x39;
        public const int WM_CONTEXTMENU = 0x7b;
        public const int WM_COPY = 0x301;
        public const int WM_COPYDATA = 0x4a;
        public const int WM_CREATE = 1;
        public const int WM_CTLCOLORBTN = 0x135;
        public const int WM_CTLCOLORDLG = 310;
        public const int WM_CTLCOLOREDIT = 0x133;
        public const int WM_CTLCOLORLISTBOX = 0x134;
        public const int WM_CTLCOLORMSGBOX = 0x132;
        public const int WM_CTLCOLORSCROLLBAR = 0x137;
        public const int WM_CTLCOLORSTATIC = 0x138;
        public const int WM_CUT = 0x300;
        public const int WM_DEADCHAR = 0x103;
        public const int WM_DELETEITEM = 0x2d;
        public const int WM_DESTROY = 2;
        public const int WM_DESTROYCLIPBOARD = 0x307;
        public const int WM_DEVICECHANGE = 0x219;
        public const int WM_DEVMODECHANGE = 0x1b;
        public const int WM_DISPLAYCHANGE = 0x7e;
        public const int WM_DRAWCLIPBOARD = 0x308;
        public const int WM_DRAWITEM = 0x2b;
        public const int WM_DROPFILES = 0x233;
        public const int WM_ENABLE = 10;
        public const int WM_ENDSESSION = 0x16;
        public const int WM_ENTERIDLE = 0x121;
        public const int WM_ENTERMENULOOP = 0x211;
        public const int WM_ENTERSIZEMOVE = 0x231;
        public const int WM_ERASEBKGND = 20;
        public const int WM_EXITMENULOOP = 530;
        public const int WM_EXITSIZEMOVE = 0x232;
        public const int WM_FONTCHANGE = 0x1d;
        public const int WM_GETDLGCODE = 0x87;
        public const int WM_GETFONT = 0x31;
        public const int WM_GETHOTKEY = 0x33;
        public const int WM_GETICON = 0x7f;
        public const int WM_GETMINMAXINFO = 0x24;
        public const int WM_GETOBJECT = 0x3d;
        public const int WM_GETTEXT = 13;
        public const int WM_GETTEXTLENGTH = 14;
        public const int WM_HANDHELDFIRST = 0x358;
        public const int WM_HANDHELDLAST = 0x35f;
        public const int WM_HELP = 0x53;
        public const int WM_HOTKEY = 0x312;
        public const int WM_HSCROLL = 0x114;
        public const int WM_HSCROLLCLIPBOARD = 0x30e;
        public const int WM_ICONERASEBKGND = 0x27;
        public const int WM_IME_CHAR = 0x286;
        public const int WM_IME_COMPOSITION = 0x10f;
        public const int WM_IME_COMPOSITIONFULL = 0x284;
        public const int WM_IME_CONTROL = 0x283;
        public const int WM_IME_ENDCOMPOSITION = 270;
        public const int WM_IME_KEYDOWN = 0x290;
        public const int WM_IME_KEYLAST = 0x10f;
        public const int WM_IME_KEYUP = 0x291;
        public const int WM_IME_NOTIFY = 0x282;
        public const int WM_IME_REQUEST = 0x288;
        public const int WM_IME_SELECT = 0x285;
        public const int WM_IME_SETCONTEXT = 0x281;
        public const int WM_IME_STARTCOMPOSITION = 0x10d;
        public const int WM_INITDIALOG = 0x110;
        public const int WM_INITMENU = 0x116;
        public const int WM_INITMENUPOPUP = 0x117;
        public const int WM_INPUTLANGCHANGE = 0x51;
        public const int WM_INPUTLANGCHANGEREQUEST = 80;
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYLAST = 0x108;
        public const int WM_KEYUP = 0x101;
        public const int WM_KILLFOCUS = 8;
        public const int WM_LBUTTONDBLCLK = 0x203;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_MBUTTONDBLCLK = 0x209;
        public const int WM_MBUTTONDOWN = 0x207;
        public const int WM_MBUTTONUP = 520;
        public const int WM_MDIACTIVATE = 0x222;
        public const int WM_MDICASCADE = 0x227;
        public const int WM_MDICREATE = 0x220;
        public const int WM_MDIDESTROY = 0x221;
        public const int WM_MDIGETACTIVE = 0x229;
        public const int WM_MDIICONARRANGE = 0x228;
        public const int WM_MDIMAXIMIZE = 0x225;
        public const int WM_MDINEXT = 0x224;
        public const int WM_MDIREFRESHMENU = 0x234;
        public const int WM_MDIRESTORE = 0x223;
        public const int WM_MDISETMENU = 560;
        public const int WM_MDITILE = 550;
        public const int WM_MEASUREITEM = 0x2c;
        public const int WM_MENUCHAR = 0x120;
        public const int WM_MENUCOMMAND = 0x126;
        public const int WM_MENUDRAG = 0x123;
        public const int WM_MENUGETOBJECT = 0x124;
        public const int WM_MENURBUTTONUP = 290;
        public const int WM_MENUSELECT = 0x11f;
        public const int WM_MOUSEACTIVATE = 0x21;
        public const int WM_MOUSEHOVER = 0x2a1;
        public const int WM_MOUSELEAVE = 0x2a3;
        public const int WM_MOUSEMOVE = 0x200;
        public const int WM_MOUSEWHEEL = 0x20a;
        public const int WM_MOVE = 3;
        public const int WM_MOVING = 0x216;
        public const int WM_NCACTIVATE = 0x86;
        public const int WM_NCCALCSIZE = 0x83;
        public const int WM_NCCREATE = 0x81;
        public const int WM_NCDESTROY = 130;
        public const int WM_NCHITTEST = 0x84;
        public const int WM_NCLBUTTONDBLCLK = 0xa3;
        public const int WM_NCLBUTTONDOWN = 0xa1;
        public const int WM_NCLBUTTONUP = 0xa2;
        public const int WM_NCMBUTTONDBLCLK = 0xa9;
        public const int WM_NCMBUTTONDOWN = 0xa7;
        public const int WM_NCMBUTTONUP = 0xa8;
        public const int WM_NCMOUSEMOVE = 160;
        public const int WM_NCPAINT = 0x85;
        public const int WM_NCRBUTTONDBLCLK = 0xa6;
        public const int WM_NCRBUTTONDOWN = 0xa4;
        public const int WM_NCRBUTTONUP = 0xa5;
        public const int WM_NEXTDLGCTL = 40;
        public const int WM_NEXTMENU = 0x213;
        public const int WM_NOTIFY = 0x4e;
        public const int WM_NOTIFYFORMAT = 0x55;
        public const int WM_NULL = 0;
        public const int WM_PAINT = 15;
        public const int WM_PAINTCLIPBOARD = 0x309;
        public const int WM_PAINTICON = 0x26;
        public const int WM_PALETTECHANGED = 0x311;
        public const int WM_PALETTEISCHANGING = 0x310;
        public const int WM_PARENTNOTIFY = 0x210;
        public const int WM_PASTE = 770;
        public const int WM_PENWINFIRST = 0x380;
        public const int WM_PENWINLAST = 0x38f;
        public const int WM_POWER = 0x48;
        public const int WM_PRINT = 0x317;
        public const int WM_PRINTCLIENT = 0x318;
        public const int WM_QUERYDRAGICON = 0x37;
        public const int WM_QUERYENDSESSION = 0x11;
        public const int WM_QUERYNEWPALETTE = 0x30f;
        public const int WM_QUERYOPEN = 0x13;
        public const int WM_QUEUESYNC = 0x23;
        public const int WM_QUIT = 0x12;
        public const int WM_RBUTTONDBLCLK = 0x206;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WM_RENDERALLFORMATS = 0x306;
        public const int WM_RENDERFORMAT = 0x305;
        public const int WM_SETCURSOR = 0x20;
        public const int WM_SETFOCUS = 7;
        public const int WM_SETFONT = 0x30;
        public const int WM_SETHOTKEY = 50;
        public const int WM_SETICON = 0x80;
        public const int WM_SETREDRAW = 11;
        public const int WM_SETTEXT = 12;
        public const int WM_SETTINGCHANGE = 0x1a;
        public const int WM_SHOWWINDOW = 0x18;
        public const int WM_SIZE = 5;
        public const int WM_SIZECLIPBOARD = 0x30b;
        public const int WM_SIZING = 0x214;
        public const int WM_SPOOLERSTATUS = 0x2a;
        public const int WM_STYLECHANGED = 0x7d;
        public const int WM_STYLECHANGING = 0x7c;
        public const int WM_SYNCPAINT = 0x88;
        public const int WM_SYSCHAR = 0x106;
        public const int WM_SYSCOLORCHANGE = 0x15;
        public const int WM_SYSCOMMAND = 0x112;
        public const int WM_SYSDEADCHAR = 0x107;
        public const int WM_SYSKEYDOWN = 260;
        public const int WM_SYSKEYUP = 0x105;
        public const int WM_TCARD = 0x52;
        public const int WM_TIMECHANGE = 30;
        public const int WM_TIMER = 0x113;
        public const int WM_UNDO = 0x304;
        public const int WM_UNINITMENUPOPUP = 0x125;
        public const int WM_USER = 0x400;
        public const int WM_USERCHANGED = 0x54;
        public const int WM_VKEYTOITEM = 0x2e;
        public const int WM_VSCROLL = 0x115;
        public const int WM_VSCROLLCLIPBOARD = 0x30a;
        public const int WM_WINDOWPOSCHANGED = 0x47;
        public const int WM_WINDOWPOSCHANGING = 70;
        public const int WM_WININICHANGE = 0x1a;
        public const uint WRITE_DAC = 0x40000;
        public const uint WRITE_OWNER = 0x80000;
        public const uint WS_BORDER = 0x800000;
        public const uint WS_CAPTION = 0xc00000;
        public const uint WS_CHILD = 0x40000000;
        public const uint WS_CHILDWINDOW = 0x40000000;
        public const uint WS_CLIPCHILDREN = 0x2000000;
        public const uint WS_CLIPSIBLINGS = 0x4000000;
        public const uint WS_DISABLED = 0x8000000;
        public const uint WS_DLGFRAME = 0x400000;
        public const uint WS_EX_ACCEPTFILES = 0x10;
        public const uint WS_EX_APPWINDOW = 0x40000;
        public const uint WS_EX_CLIENTEDGE = 0x200;
        public const uint WS_EX_CONTEXTHELP = 0x400;
        public const uint WS_EX_CONTROLPARENT = 0x10000;
        public const uint WS_EX_DLGMODALFRAME = 1;
        public const uint WS_EX_LAYERED = 0x80000;
        public const uint WS_EX_LEFT = 0;
        public const uint WS_EX_LEFTSCROLLBAR = 0x4000;
        public const uint WS_EX_LTRREADING = 0;
        public const uint WS_EX_MDICHILD = 0x40;
        public const uint WS_EX_NOPARENTNOTIFY = 4;
        public const uint WS_EX_OVERLAPPEDWINDOW = 0x300;
        public const uint WS_EX_PALETTEWINDOW = 0x188;
        public const uint WS_EX_RIGHT = 0x1000;
        public const uint WS_EX_RIGHTSCROLLBAR = 0;
        public const uint WS_EX_RTLREADING = 0x2000;
        public const uint WS_EX_STATICEDGE = 0x20000;
        public const uint WS_EX_TOOLWINDOW = 0x80;
        public const uint WS_EX_TOPMOST = 8;
        public const uint WS_EX_TRANSPARENT = 0x20;
        public const uint WS_EX_WINDOWEDGE = 0x100;
        public const uint WS_GROUP = 0x20000;
        public const uint WS_HSCROLL = 0x100000;
        public const uint WS_ICONIC = 0x20000000;
        public const uint WS_MAXIMIZE = 0x1000000;
        public const uint WS_MAXIMIZEBOX = 0x10000;
        public const uint WS_MINIMIZE = 0x20000000;
        public const uint WS_MINIMIZEBOX = 0x20000;
        public const uint WS_OVERLAPPED = 0;
        public const uint WS_OVERLAPPEDWINDOW = 0xcf0000;
        public const uint WS_POPUP = 0x80000000;
        public const uint WS_POPUPWINDOW = 0x80880000;
        public const uint WS_SIZEBOX = 0x40000;
        public const uint WS_SYSMENU = 0x80000;
        public const uint WS_TABSTOP = 0x10000;
        public const uint WS_THICKFRAME = 0x40000;
        public const uint WS_TILED = 0;
        public const uint WS_TILEDWINDOW = 0xcf0000;
        public const uint WS_VISIBLE = 0x10000000;
        public const uint WS_VSCROLL = 0x200000;

        //调用API
        //获得本窗体的句柄
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        //设置此窗体为活动窗体
        //[System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        //public static extern bool SetForegroundWindow(IntPtr hWnd);
        
        [DllImport("user32")]
        public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);
        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, uint dwRop);
        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, uint hTemplateFile);
        [DllImport("Kernel32.dll", CharSet=CharSet.Auto)]
        public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, SecurityAttributes lpProcessAttributes, SecurityAttributes lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, string lpEnvironment, string lpCurrentDirectory, ref StartupInfo lpStartupInfo, ref ProcessInfo lpProcessInformation);
        [DllImport("Kernel32.dll")]
        public static extern bool DefineDosDevice(int dwFlags, string lpDeviceName, string lpTargetPath);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern bool DragDetect(IntPtr hWnd, Point pt);
        [DllImport("User32.dll", SetLastError=true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll", SetLastError=true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);
        [DllImport("User32.dll")]
        public static extern bool GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool GetCommTimeouts(IntPtr hFile, ref CommTimeouts lpCommTimeouts);
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool GetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);
        [DllImport("Kernel32.dll", CharSet=CharSet.Auto)]
        public static extern int GetCurrentThreadId();
        [DllImport("User32.dll ")]
        public static extern int GetCursorPos(ref Point lpPoint);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr ptr);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern IntPtr GetFocus();
        [DllImport("Kernel32.dll")]
        public static extern void GetLocalTime(ref SystemTime sysTime);
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("User32.dll ")]
        public static extern int GetWindowRect(IntPtr hwnd, ref Rectangle lpRect);
        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        [DllImport("User32.dll")]
        public static extern bool PtInRect(ref Rectangle lpRect, Point lpPoint);
        [DllImport("kernel32.dll")]
        public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);
        [DllImport("kernel32.dll")]
        public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToRead, out int lpNumberOfBytesRead, int lpOverlapped);
        [DllImport("kernel32.dll")]
        public static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToRead, out int lpNumberOfBytesRead, ref Overlapped lpOverlapped);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern uint SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern uint SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool SetCommTimeouts(IntPtr hFile, ref CommTimeouts lpCommTimeouts);
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern bool SetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern IntPtr SetFocus(IntPtr hWnd);
        // 设置置顶
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, int crKey, int bAlpha, uint dwFlags);
        [DllImport("Kernel32.dll")]
        public static extern bool SetLocalTime(ref SystemTime sysTime);
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern uint SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int Width, int Height, uint uFlags);
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hmod, int dwThreadId);
        [DllImport("shell32.dll")]
        public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, short nShowCmd);
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        [DllImport("User32.dll", CharSet=CharSet.Auto)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("User32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hwnd, int cmdShow);
        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);
        [DllImport("user32.dll", CharSet=CharSet.Auto)]
        public static extern IntPtr WindowFromPoint(Point point);
        [DllImport("kernel32.dll", SetLastError=true)]
        public static extern int WinExec(string exeName, short operType);
        [DllImport("kernel32.dll")]
        public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, out int lpNumberOfBytesWritten, ref Overlapped lpOverlapped);
        [DllImport("kernel32.dll")]
        public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, out int lpNumberOfBytesWritten, int lpOverlapped);
        [DllImport("kernel32.dll")]
        public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);

        //TAO ADD 
        [ DllImport( "user32.dll",  CharSet = CharSet.Auto ) ]
        public static extern bool SwitchToThisWindow( IntPtr hWnd,  bool fAltTab );
        


        [StructLayout(LayoutKind.Sequential)]
        public struct CommTimeouts
        {
            public int readIntervalTimeout;
            public int readTotalTimeoutMultiplier;
            public int readTotalTimeoutConstant;
            public int writeTotalTimeoutMultiplier;
            public int writeTotalTimeoutConstant;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COMMTIMEOUTS
        {
            public int ReadIntervalTimeout;
            public int ReadTotalTimeoutMultiplier;
            public int ReadTotalTimeoutConstant;
            public int WriteTotalTimeoutMultiplier;
            public int WriteTotalTimeoutConstant;
        }

        public delegate IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct Overlapped
        {
            public IntPtr intrnal;
            public IntPtr internalHigh;
            public int offset;
            public int offsetHigh;
            public IntPtr hEvent;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct OVERLAPPED
        {
            private int Internal;
            private int InternalHigh;
            private int Offset;
            private int OffSetHigh;
            private int hEvent;
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
        public struct ProcessInfo
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int ProcessId;
            public int ThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class SecurityAttributes
        {
            public int length;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
        public struct StartupInfo
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public int dwX;
            public int dwY;
            public int dwXSize;
            public int dwYSize;
            public int dwXCountChars;
            public int dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SystemTime
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMiliseconds;
        }
    }
}
