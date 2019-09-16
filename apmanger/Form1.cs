using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apmanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_apache_Click(object sender, EventArgs e)
        {
            // APNode.run_appache(HandlerApache);
            String str_out = "";
            String str_err = "";
            APNode.ExecuteCommand("CMD /K dir ", out str_out, out str_err);
            rich_main.Text = str_out;

        }
        private void HandlerApache(object sendingProcess, DataReceivedEventArgs outLine)
        {
            try
            {
                // Console.WriteLine(outLine.Data);
                rich_main.Text = outLine.Data;
            }
            catch (Exception ex)
            {
                rich_main.Text += "ERROR:" + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rich_main.Text = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
