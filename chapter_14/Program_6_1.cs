using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace chapter_14
{
    class Program_6_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting program");
            var saveColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Blue;
            var info = new ProcessStartInfo("cmd", "/c time");
            info.UseShellExecute = false;
            var proc = Process.Start(info);
            proc.WaitForExit();

            Console.BackgroundColor = saveColor;
            Console.WriteLine("Program exited");
            Console.ReadLine();
        }
    }
}
