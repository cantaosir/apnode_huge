using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//public delegate int Compile(String command, StringBuilder inf);//编译
//DllInvoke dll ＝ new DllInvoke(Server.MapPath(@"~/Bin/Judge.dll"));
//Compile compile = (Compile)dll.Invoke("Compile", typeof(Compile));
//StringBuilder inf;
//compile(@“gcc a.c -o a.exe“,inf); //这里就是调用我的DLL里定义的Compile函数

namespace Util
{
    public class InvokeDll
    {
        [DllImport("User32.dll")]
        static extern Boolean MessageBeep(UInt32 beepType);
        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(String path);
        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr lib, String funcName);
        [DllImport("kernel32.dll")]
        private extern static bool FreeLibrary(IntPtr lib);
        private IntPtr hLib;
        public InvokeDll(String DLLPath)
        {
            hLib = LoadLibrary(DLLPath);
        }
        ~InvokeDll()
        {
            FreeLibrary(hLib);
        }
        //将要执行的函数转换为委托
        public Delegate Invoke(String APIName, Type t)
        {
            IntPtr api = GetProcAddress(hLib, APIName);
            return (Delegate)Marshal.GetDelegateForFunctionPointer(api, t);
        }

        //public static string ReleaseTo(Resource res , String toFile)
        //{
        // string tempFile = Path.GetTempFileName();//临时文件准尉
        // toFile
        // byte[] byDll = Resource1.test;//看这里看这里。我之前的文件是test.img这里直接就能获取到目标的byte[]数据了
        // File.WriteAllBytes(tempFile, byDll);//释放了dll到临时文件
        //文件释放出来给DllInvoke导出函数哈哈哈
        // Clipboard.SetDataObject(tempFile, true);
        // MessageBox.Show("temp resource file -> " + tempFile + " size ->" + byDll.GetLength(0).ToString());
        //  byte[] bytes = Resource.DLL_AAPT;
        //	File.WriteAllBytes(toFile, bytes);
        //  return toFile;
        //}
    }
}
