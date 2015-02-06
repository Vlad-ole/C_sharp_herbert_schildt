using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    // Продемонстрировать применение анонимного метода, возвращающего значение.

    // Этот делегат возвращает значение.
    delegate int CountIt(int end);

    class Program_7
    {


        static void Main(string[] args)
        {
            int result;
            
            // Здесь конечное значение для подсчета перелается анонимному методу.
            // А возвращается сумма подсчитанных чисел.
            CountIt count = delegate(int end)
            {
                int sum = 0;
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum; // возвратить значение из анонимного метода
            };

            result = count(3);
            Console.WriteLine("Сумма 3 равна " + result);
            
            Console.WriteLine();
            
            result = count(5);
            Console.WriteLine("Сумма 5 равна " + result);


            Console.ReadKey();
        }
    }
}
