using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
namespace Util
{
    class WinTray
    {
        // 消息提示
        private static String _msg = "";
        public static string Msg
        {
            get { return _msg; }
            set { _msg = value; }
        }

        //Tray右键菜单
        public static ContextMenu local_cm = new ContextMenu();
        public static MenuItem[] local_ami = null;
        public static MenuItem[] add_menu(ref MenuItem[] mis_src, string strName, string strText)
        {
            MenuItem[] mis_ret = new MenuItem[mis_src.Length + 1];
            MenuItem mi = new MenuItem { Name = strName, Text = strText };
            mis_src.CopyTo(mis_ret, 0);
            mis_ret[mis_src.Length] = mi;
            mis_src = mis_ret;
            return mis_ret;
        }
        //右键菜单初始化
        public static void context_init()
        {
            EventHandler eh = new EventHandler(tray_Context_Click);
            local_ami = new MenuItem[] { };
            // 菜单
            add_menu(ref local_ami, "Consume", "消费");
            add_menu(ref local_ami, "Charge", "充值");
            add_menu(ref local_ami, "Activate", "激活");
            add_menu(ref local_ami, "Option", "选项");
            // 退出
            add_menu(ref local_ami, "Exit", "退出");
            //添加处理事件
            foreach (MenuItem mi_loop in local_ami)
            {
                mi_loop.Click += eh;
            }
            //设定Context
            local_cm = new ContextMenu(local_ami);
        }

        //Tray图标
        public static NotifyIcon notify_icon_base;
        // (Icon)Properties.Resources.IconTray;
        public static Icon notify_icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        //菜单事件
        private static void tray_Context_Click(object sender, EventArgs e)
        {
            MenuItem mi_click = (MenuItem)sender;
            switch ((mi_click).Name)
            {
                // 发卡
                case "Activate":
                    break;
                //消费
                case "Consume":
                    break;
                //充值
                case "Charge":
                    break;
                //调试
                case "Option":
                    break;
                //退出
                case "Exit":
                    break;
                default: break;
            }
        }
        // 点击事件
        private static void tray_Click(object sender, EventArgs e)
        {

        }
        //图标初始化
        public static void tray_init()
        {
            notify_icon_base = new System.Windows.Forms.NotifyIcon();
            notify_icon_base.BalloonTipText = "跳出字体";
            notify_icon_base.Text = "Notify";
            notify_icon_base.Icon = notify_icon;
            //右键跳出主窗口菜单
            notify_icon_base.ContextMenu = local_cm;
            //左键点击打开窗口
            notify_icon_base.Click += new System.EventHandler(tray_Click);

            //显示托盘图标
            notify_icon_base.Visible = true;

        }
        //关闭图标
        public static void tray_hide()
        {
            notify_icon_base.Visible = false;
        }
        //显示图标
        public static void tray_show()
        {
            if (notify_icon_base == null)
            {
                tray_init();
            }
            notify_icon_base.Visible = true;
        }
    }
}
