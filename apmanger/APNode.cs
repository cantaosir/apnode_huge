using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace apmanger
{
    class APNode
    {
        public static String _root = "C:\apnode";

        // 检查并初始化
        public static String _init_msg = "";
        public static void init() {
            _root = AppDomain.CurrentDomain.BaseDirectory;
            _init_msg += "基础目录："+_root;
        }
        public static bool check_exist(String path) {
            try
            {
                return Directory.Exists(_root + path);
            }
            catch (Exception ex) {
                ex.ToString();
            }
            return false;
        }
        public static void exec_sync(string cmd,string arg,DataReceivedEventHandler OutputHandler)
        {
            try{
                Process process = new Process();
                process.StartInfo.FileName = cmd;
                process.StartInfo.Arguments = arg;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }catch (Exception ex){
                if (Program.mainForm != null) {
                    Program.mainForm.Text = ex.Message +">>"+ ex.ToString();
                } 
            }
        }

        /// <summary>
        /// 执行一条command命令
        /// </summary>
        /// <param name="command">需要执行的Command</param>
        /// <param name="output">输出</param>
        /// <param name="error">错误</param>
        public static void ExecuteCommand(string command, string arguments, out string output, out string error)
        {
            try
            {
                Program.hideMainFrom();
                //创建一个进程
                Process process = new Process();
                process.StartInfo.FileName = command;

                // 必须禁用操作系统外壳程序
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                //启动进程
                process.Start();

                //准备读出输出流和错误流
                string outputData = string.Empty;
                string errorData = string.Empty;
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.OutputDataReceived += (sender, e) =>
                {
                    outputData += (e.Data + "\n");
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    errorData += (e.Data + "\n");
                };

                //等待退出
                process.WaitForExit();

                //关闭进程
                process.Close();

                //返回流结果
                output = outputData;
                error = errorData;
            }
            catch (Exception)
            {
                output = null;
                error = null;
            }
            Program.showMainFrom();
        }

        static void OutputHandler2(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Console.WriteLine(outLine.Data);
        }
    }
}
