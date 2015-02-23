using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public static class run
    {
        public static string runProgram(string appPath, string arguments, string startFolder)
        {
            string textOP = "";
            System.Diagnostics.ProcessStartInfo procStartInfoB = new System.Diagnostics.ProcessStartInfo(appPath, arguments);
            procStartInfoB.RedirectStandardOutput = true;
            procStartInfoB.UseShellExecute = false;
            procStartInfoB.CreateNoWindow = true;
            System.Diagnostics.Process procB = new System.Diagnostics.Process();
            procB.StartInfo = procStartInfoB;
            procB.StartInfo.WorkingDirectory = startFolder;
            procB.Start();
            string resultB = procB.StandardOutput.ReadToEnd();
            procB.WaitForExit();
            textOP = textOP + resultB + Environment.NewLine;
            Console.Write(resultB);
            return textOP;
        }
        public static string runProgram(string appPath, string arguments)
        {
            string textOP = "";
            System.Diagnostics.ProcessStartInfo procStartInfoB = new System.Diagnostics.ProcessStartInfo(appPath, arguments);
            procStartInfoB.RedirectStandardOutput = true;
            procStartInfoB.UseShellExecute = false;
            procStartInfoB.CreateNoWindow = true;
            System.Diagnostics.Process procB = new System.Diagnostics.Process();
            procB.StartInfo = procStartInfoB;
            procB.Start();
            string resultB = procB.StandardOutput.ReadToEnd();
            procB.WaitForExit();
            textOP = textOP + resultB + Environment.NewLine;
            Console.Write(resultB);
            return textOP;
        }
        public static string runProgram(string appPath)
        {
            string textOP = "";
            System.Diagnostics.ProcessStartInfo procStartInfoB = new System.Diagnostics.ProcessStartInfo(appPath);
            procStartInfoB.RedirectStandardOutput = true;
            procStartInfoB.UseShellExecute = false;
            procStartInfoB.CreateNoWindow = true;
            System.Diagnostics.Process procB = new System.Diagnostics.Process();
            procB.StartInfo = procStartInfoB;
            procB.Start();
            string resultB = procB.StandardOutput.ReadToEnd();
            procB.WaitForExit();
            textOP = textOP + resultB + Environment.NewLine;
            Console.Write(resultB);
            return textOP;
        }
    }
}
