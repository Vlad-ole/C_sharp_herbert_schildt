using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_7
    {
        static void Main(string[] args)
        {

            // Применить поразрядный оператор И, чтобы сделать число четным.

            ushort num;
            ushort i;
            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);
                num = (ushort)(num & 0xFFFE);
                Console.WriteLine("num после сброса младшего разряда: "
                + num + "\n");
            }

            Console.ReadKey();
        }
    }
}
