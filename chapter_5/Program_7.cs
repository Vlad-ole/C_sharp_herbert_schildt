using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_7
    {
        static void Main(string[] args)
        {

            // Выполнение цикла for в отрицательном направлении.

            int x;
            for (x = 100; x > -100; x -= 5)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
