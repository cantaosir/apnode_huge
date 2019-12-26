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
        private String base_path = AppDomain.CurrentDomain.BaseDirectory;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try {
               //  Util.WinTray.tray_init();
            }
            catch (Exception ex) { }
            rich_main.Text = AppDomain.CurrentDomain.BaseDirectory;
            APNode.exec_sync("cmd", "/c dir /a /b winsw*", handleDataReceivedEvent);
            Program.showMainFrom();
        }
        private void handleDataReceivedEvent(object sender, DataReceivedEventArgs e) {
            try {
                // rich_main.Text += sender.ToString() + "\n";
                // rich_main.Text += e.Data.ToString() + "\n";
            }
            catch (Exception ex) {
                ex.ToString();
            }
        }
        //串口数据接收事件


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private String execute(String cmd, String arg)
        {
            String str_out = "";
            String str_err = "";
            APNode.ExecuteCommand(cmd, arg, out str_out, out str_err);
            return str_out;
        }
        private String base_exec(String cmd, String arg)
        {
            String str_out = "";
            String str_err = "";
            APNode.ExecuteCommand(base_path+cmd, arg, out str_out, out str_err);
            return str_out;
        }

        private void btn_apache_Click(object sender, EventArgs e)
        {
            // APNode.run_appache(HandlerApache);
            // String str_out = "";
            // String str_err = "";
            // APNode.ExecuteCommand("CMD", "/C dir /a /b /w winsw* ",out str_out, out str_err);
           //  rich_main.Text = execute("WinswApache22\\WinswApache22.exe", "/C dir /a /b /w winsw* ");
            rich_main.AppendText(base_exec("apache22\\WinswApache22.exe", "restart") );
        }

        private void btn_mysql_Click(object sender, EventArgs e)
        {
            rich_main.AppendText(base_exec("WinswMySQL57x64\\WinswMySQL57x64.exe", "restart"));
        }

        private void btn_nginx_Click(object sender, EventArgs e)
        {
            rich_main.AppendText(base_exec("WinswNginx\\WinswNginx.exe", "restart"));
        }

        private void btn_php56_Click(object sender, EventArgs e)
        {
            rich_main.AppendText(base_exec("WinswPHP56x64NTS\\WinswPHP56x64NTS.exe", "restart"));
        }

        private void btn_redis_Click(object sender, EventArgs e)
        {
            rich_main.AppendText(base_exec("WinswRedisServer\\WinswRedisServer.exe", "restart"));
        }

        private void btn_Memcache_Click(object sender, EventArgs e)
        {
            rich_main.AppendText(base_exec("WinswMemcached\\WinswMemcached.exe", "restart"));
        }

        private void btn_filezilla_Click(object sender, EventArgs e)
        {
            rich_main.AppendText(base_exec("FileZillaServer\\FileZilla Server.exe", ""));
        }
    }
}
