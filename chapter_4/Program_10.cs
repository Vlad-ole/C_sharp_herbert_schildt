using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_10
    {
        static void Main(string[] args)
        {

            // Применить поразрядный оператор ИЛИ, чтобы сделать число нечетным.

            ushort num;
            ushort i;
            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);
                num = (ushort)(num | 1);
                Console.WriteLine("num после установки младшего разряда: " +
                num + "\n");
            }

            Console.ReadKey();
        }
    }
}
