using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_14
{
    // Организовать вывод в потоки Console.Out и Console.Error.

    class Program_5
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            int result;
            Console.Out.WriteLine("Деление на нуль приведет " + "к исключительной ситуации.");

            try
            {
                result = a / b; // сгенерировать исключение при попытке деления на нуль
            }

            catch (DivideByZeroException exc)
            {
                Console.Error.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
