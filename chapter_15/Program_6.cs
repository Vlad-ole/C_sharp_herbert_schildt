using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Продемонстрировать применение анонимного метода, принимающего аргумент.

    // Обратите внимание на то, что теперь у делегата CountIt имеется параметр.
    delegate void CountIt(int end);


    class Program_6
    {


        static void Main(string[] args)
        {

            // Здесь конечное значение для подсчета передается анонимному методу.
            CountIt count = delegate(int end)
            {
                for (int i = 0; i <= end; i++)
                    Console.WriteLine(i);
            };

            count(3);
            Console.WriteLine();
            count(5);

            Console.ReadKey();
        }
    }
}
