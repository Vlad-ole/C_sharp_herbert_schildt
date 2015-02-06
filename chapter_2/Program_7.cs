using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
    class Program_7
    {
        static void Main(string[] args)
        {
            int i, j, d;
            i = 5;
            j = 10;
            // Адресатом этого оператора if служит кодовый блок.
            if (i != 0)
            {
                Console.WriteLine("i не равно нулю");
                d = j / i;
                Console.WriteLine("j / i равно " + d);
            }

            Console.ReadKey();
        }
    }
}
