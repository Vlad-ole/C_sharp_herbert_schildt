using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_21
    {
        static void Main(string[] args)
        {

            double n;
            for (n = 1.0; n <= 10; n++)
            {
                Console.WriteLine("Квадратный корень из {0} равен {1}",
                n, Math.Sqrt(n));
                Console.WriteLine("Целая часть числа: {0}",
                (int)Math.Sqrt(n));
                Console.WriteLine("Дробная часть числа: {0}",
                Math.Sqrt(n) - (int)Math.Sqrt(n));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
