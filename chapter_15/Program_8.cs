using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    // Продемонстрировать применение захваченной переменной.

    // Этот делегат возвращает значение типа int и принимает аргумент типа int.
    delegate int CountIt(int end);

    class Program_8
    {
       
        static CountIt Counter()
        {
            int sum = 0;
            // Здесь подсчитанная сумма сохраняется в переменной sum.
            CountIt ctObj = delegate(int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };

            return ctObj;
        }

        static void Main(string[] args)
        {
            // Получить результат подсчета.
            CountIt count = Counter();
            
            int result;
            
            result = count(3);
            Console.WriteLine("Сумма 3 равна " + result);
            Console.WriteLine();
            
            result = count(5);
            Console.WriteLine("Сумма 5 равна " + result);


            Console.ReadKey();
        }
    }
}
