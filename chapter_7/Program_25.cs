using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace chapter_7
{
    class Program_25
    {
        // Продемонстрировать управление оператором switch посредством строк.

        static void Main(string[] args)
        {
            string[] strs = { "один", "два", "три", "два", "один" };
            foreach (string s in strs)
            {
                switch (s)
                {
                    case "один":
                        Console.Write(1);

                        break;
                    case "два":
                        Console.Write(2);
                        break;
                    case "три":
                        Console.Write(3);
                        break;
                }
            }
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
