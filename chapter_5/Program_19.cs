using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_19
    {
        static void Main(string[] args)
        {

            // Применить оператор break для выхода из цикла.

            // Использовать оператор break для выхода из этого цикла.
            for (int i = -10; i <= 10; i++)
            {
                if (i > 0) break; // завершить цикл, как только значение
                // переменной i станет положительным
                Console.Write(i + " ");
            }
            Console.WriteLine("Готово!");
            
            Console.ReadKey();
        }
    }

}
