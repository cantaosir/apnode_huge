using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apmanger
{
    static class Program
    {
        public static APNode apnode = new APNode();
        public static Form1 mainForm;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new Form1();
            Application.Run(mainForm);
        }
        public static void hideMainFrom() {
            if (mainForm != null) {
                mainForm.TopMost = false;
                mainForm.WindowState = FormWindowState.Minimized;
            }
        }
        public static void showMainFrom()
        {
            if (mainForm != null)
            {
                mainForm.TopMost = false;
                mainForm.WindowState = FormWindowState.Normal;
            }
        }
    }
}
