using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    // Продемонстрировать применение блочного лямбда-выражения.

    // Делегат IntOp принимает один аргумент типа int
    // и возвращает результат типа int.
    delegate int IntOp(int end);

    class Program_10
    {


        static void Main(string[] args)
        {

            // Блочное лямбда-выражение возвращает факториал
            // передаваемого ему значения.
            IntOp fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                    r = i * r;
                return r;
            };

            Console.WriteLine("Факториал 3 равен " + fact(3));
            Console.WriteLine("Факториал 5 равен " + fact(5));

            Console.ReadKey();
        }
    }
}
