using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_15
    {
        static void Main(string[] args)
        {

            // Исключить деление на нуль, используя оператор?.

            int result;
            for (int i = -5; i < 6; i++)
            {
                result = i != 0 ? 100 / i : 0;
                if (i != 0)
                    Console.WriteLine("100 / " + i + " равно " + result);
            }

            Console.ReadKey();
        }
    }
}
