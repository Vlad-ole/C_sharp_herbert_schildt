using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_2
    {
        static void Main(string[] args)
        {
            byte x;
            int sum;
            sum = 0;

            for (x = 1; x <= 100; x++)
                sum = sum + x;
            Console.WriteLine("Сумма чисел от 1 до 100 равна " + sum);

            Console.ReadKey();
        }
    }
}
