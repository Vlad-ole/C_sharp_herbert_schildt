using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_18
    {
        static void Main(string[] args)
        {

            // Отобразить цифры целого числа в обратном порядке.

            int num;
            int nextdigit;
            num = 198;
            Console.WriteLine("Число: " + num);
            Console.Write("Число в обратном порядке: ");
            do
            {
                nextdigit = num % 10;
                Console.Write(nextdigit);
                num = num / 10;
            } while (num > 0);
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }

}
