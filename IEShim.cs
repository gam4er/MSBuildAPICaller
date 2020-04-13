using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace MyTasks
{
    public class SimpleTask : Task
    {
        public override bool Execute()
        {
            Console.ReadLine();
            ApcInjectionNewProcess.Exec(this.MyCode,this.MyProcess);            
            return true;
        }
        public string MyProperty { get; set; }
        public string MyCode { get; set; }
        public string MyProcess { get; set; }
        
    }
}
public class ApcInjectionNewProcess
{
    public static void Exec(string a, string b)
    {
        //byte[] shellcode = System.Convert.FromBase64String(a);
        //string processpath = b;

        using (Process myProcess = new Process())
        {
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.StartInfo.Arguments = "/c ping -t ya.ru";
            myProcess.Start();
            Console.ReadLine();
        }

    }
    
}