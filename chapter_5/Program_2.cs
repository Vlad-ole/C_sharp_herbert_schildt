using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_2
    {
        static void Main(string[] args)
        {

            // Определить, является ли числовое значение
            // положительным, отрицательным или нулевым.

            int i;
            for (i = -5; i <= 5; i++)
            {
                Console.Write("Проверка " + i + ": ");
                if (i < 0) Console.WriteLine("отрицательное число");
                else if (i == 0) Console.WriteLine("число без знака");
                else Console.WriteLine("положительное число");
            }

            Console.ReadKey();
        }
    }
}
