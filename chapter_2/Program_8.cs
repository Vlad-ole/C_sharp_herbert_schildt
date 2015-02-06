using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
    class Program_8
    {
        static void Main(string[] args)
        {
            int prod;
            int sum;
            int i;
            sum = 0;
            prod = 1;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Произведение равно " + prod);

            Console.ReadKey();
        }
    }
}
