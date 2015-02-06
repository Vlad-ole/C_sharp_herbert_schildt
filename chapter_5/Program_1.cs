using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_1
    {
        static void Main(string[] args)
        {

            // Определить, является ли числовое значение положительным или отрицательным.

            int i;
            for (i = -5; i <= 5; i++)
            {
                Console.Write("Проверка " + i);
                if (i < 0) Console.WriteLine("отрицательное число");
                else Console.WriteLine("положительное число");
            }

            Console.ReadKey();
        }
    }
}
