using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buildframe.Methods
{
    public class DebugMethods
    {
        [DllImport("kernel32.dll")] public static extern bool AllocConsole();

        public static void WriteLineIfDebug(string s = "", bool allowPrint = true)
        {
            if (ToolDebug && (allowPrint || DebuggingFull))
                Console.WriteLine(s);
        }

        public static void WriteIfDebug(string s = "")
        {
            if (ToolDebug)
                Console.Write(s);
        }

        public static void ThreadedMessage(string Message, string TitleAppend = "")
        {
            void msgbx()
            {
                MessageBox.Show(Message, ToolName + TitleAppend);
            }
            Thread msg = new Thread(msgbx);
            msg.Start();
        }
    }
}
