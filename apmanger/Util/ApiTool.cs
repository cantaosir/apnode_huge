using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;
using System.Net.NetworkInformation;

namespace Util
{
    public class ApiTool
    {
        //根据进程,前置程序窗口
        public static void ProcessShow(string strProcessName)
        {
            Process[] processListCurrent = Process.GetProcesses();//得到系统中存在的进程  
            string strTempProcessName = "";
            for (int i = 0; i < processListCurrent.Length; i++)
            {
                strTempProcessName = processListCurrent[i].ProcessName;
                //这里是得到你需要置前的进程窗体，我这里以迅雷为例  
                if (strTempProcessName.ToLower() == strProcessName.ToLower())
                {
                    //后面那个参数1代表正常窗口显示，2代表最小化显示，3代表最大化显示  
                    //MessageBox.Show("只能运行一个Seisgram程序" + strTempProcessName, "请确定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_FORCEMINIMIZE);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_HIDE);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_NORMAL);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWMAXIMIZED);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWNOACTIVATE);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWNORMAL);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_MAX);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWMAXIMIZED);
                    WinAPI.SetForegroundWindow(processListCurrent[i].MainWindowHandle);
                    WinAPI.SwitchToThisWindow(processListCurrent[i].MainWindowHandle, true);
                }
            }
        }
        //根据进程,前置程序窗口
        public static void ProcessMini(string strProcessName)
        {
            Process[] processCurrent = Process.GetProcesses();//得到系统中存在的进程  
            string strTempProcessName = "";
            for (int i = 0; i < processCurrent.Length; i++)
            {
                strTempProcessName = processCurrent[i].ProcessName;
                //这里是得到你需要置前的进程窗体，我这里以迅雷为例  
                if (strTempProcessName.ToLower() == strProcessName.ToLower())
                {
                    //后面那个参数1代表正常窗口显示，2代表最小化显示，3代表最大化显示  
                    //MessageBox.Show("只能运行一个Seisgram程序" + strTempProcessName, "请确定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_FORCEMINIMIZE);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_HIDE);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_NORMAL);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWMAXIMIZED);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWNOACTIVATE);
                    //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWNORMAL);
                    //WinAPI.SetForegroundWindow(processCurrent[i].MainWindowHandle);
                    WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_MINIMIZE);
                }
            }
        }
        //根据进程,前置程序窗口
        public static void ProcessMinimizeAll()
        {
            Process[] processCurrent = Process.GetProcesses();//得到系统中存在的进程  
            string strTempProcessName = "";
            for (int i = 0; i < processCurrent.Length; i++)
            {
                strTempProcessName = processCurrent[i].ProcessName;
                //后面那个参数1代表正常窗口显示，2代表最小化显示，3代表最大化显示  
                //MessageBox.Show("只能运行一个Seisgram程序" + strTempProcessName, "请确定", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_FORCEMINIMIZE);
                //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_HIDE);
                //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_NORMAL);
                //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWMAXIMIZED);
                //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWNOACTIVATE);
                //WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWNORMAL);
                //WinAPI.SetForegroundWindow(processCurrent[i].MainWindowHandle);
                WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_MINIMIZE);
                WinAPI.ShowWindow(processCurrent[i].MainWindowHandle, WinAPI.SW_SHOWMINIMIZED);

            }
        }

        public static bool ProcessStart(string strProcessExecName)
        {
            return ProcessStart(strProcessExecName, "");
        }
        public static bool ProcessStart(string strProcessExecName, string strArguments)
        {
            if (!File.Exists(strProcessExecName))
            {
                return false;
            }
            //定义一个ProcessStartInfo实例
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            //设置启动进程的初始目录
            info.WorkingDirectory = Application.StartupPath;
            //设置启动进程的应用程序或文档名
            info.FileName = strProcessExecName;
            //设置启动进程的参数
            info.Arguments = strArguments;
            //启动由包含进程启动信息的进程资源
            //info.UseShellExecute = true;
            //info.Verb = "runas";
            try
            {
                System.Diagnostics.Process.Start(info);
            }
            catch (System.ComponentModel.Win32Exception we)
            {
                MessageBox.Show(we.Message);
                return false;
            }
            return true;
        }
        //检查是否是管理员
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        //取得MAC地址
        public static string GetMacAddress()
        {
            return GetMacAddressByNetworkInformation("");
        }
        public static string GetMacAddressByNetworkInformation(string strSplit = "")
        {
            string macAddress = "";
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in nics)
                {
                    if (!adapter.GetPhysicalAddress().ToString().Equals(""))
                    {
                        macAddress = adapter.GetPhysicalAddress().ToString();
                        for (int i = 1; i < 6; i++)
                        {
                            macAddress = macAddress.Insert(3 * i - 1, strSplit);
                        }
                        break;
                    }
                }

            }
            catch
            {
            }
            return macAddress;
        }

    }
}
