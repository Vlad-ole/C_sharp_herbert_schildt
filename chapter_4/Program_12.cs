using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_12
    {
        static void Main(string[] args)
        {

            // Продемонстрировать применение поразрядного унарного оператора НЕ.

            sbyte b = -34;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            // обратить все биты
            b = (sbyte)~b;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }

            Console.ReadKey();
        }
    }
}
