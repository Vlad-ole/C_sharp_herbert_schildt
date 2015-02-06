using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{
    // Продемонстрировать применение ключевых слов checked и unchecked.

    class Program_16
    {
        static void Main(string[] args)
        {
            byte a, b;
            byte result;
            a = 127;
            b = 127;
            
            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Непроверенный на переполнение результат: " + result);
                
                result = checked((byte)(a * b)); // эта операция приводит к исключительной ситуации
                Console.WriteLine("Проверенный на переполнение результат: " + result); //не подлежит выполнению
            }
            
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }

            Console.ReadKey();
        }
    }
}
