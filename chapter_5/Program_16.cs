using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_16
    {
        static void Main(string[] args)
        {

            // Вычислить порядок величины целого числа.

            int num;
            int mag;
            num = 435679;
            mag = 0;
            Console.WriteLine("Число: " + num);
            while (num > 0)
            {
                mag++;
                num = num / 10;
            };
            Console.WriteLine("Порядок величины: " + mag);

            Console.ReadKey();
        }
    }

}
