using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace chapter_8
{
    // Вывести символьную строку в обратном порядке, используя рекурсию.

    class RevStr
    {
        // Вывести символьную строку в обратном порядке.
        public void DisplayRev(string str)
        {
            if (str.Length > 0)
                DisplayRev(str.Substring(1, str.Length - 1));
            else
                return;
            Console.Write(str[0]);
        }
    }

    class Program_29
    {

        static void Main(string[] args)
        {
            string s = "Это тест";
            
            RevStr rsOb = new RevStr();
            Console.WriteLine("Исходная строка: " + s);
            Console.Write("Перевернутая строка: ");
            rsOb.DisplayRev(s);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
