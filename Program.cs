using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.StartInfo.Arguments = "/c ping -t ya.ru";
            myProcess.Start();
            Console.ReadLine();
        }
    }
}
