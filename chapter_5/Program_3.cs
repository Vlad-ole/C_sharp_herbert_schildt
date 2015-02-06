using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_3
    {
        static void Main(string[] args)
        {

            int num;
            for (num = 2; num < 12; num++)
            {
                if ((num % 2) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 2.");
                else if ((num % 3) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 3.");
                else if ((num % 5) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 5.");
                else if ((num % 7) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 7.");
                else
                    Console.WriteLine(num + " не делится на 2, 3, 5 или 7.");
            }

            Console.ReadKey();
        }
    }
}
