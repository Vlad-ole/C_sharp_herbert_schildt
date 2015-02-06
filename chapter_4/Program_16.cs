using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_16
    {
        static void Main(string[] args)
        {

            // Разделить только на четные, ненулевые значения.

            for (int i = -5; i < 6; i++)
                if (i != 0 ? (i % 2 == 0) : false)
                    Console.WriteLine("100 / " + i + " равно " + 100 / i);


            Console.ReadKey();
        }
    }
}
