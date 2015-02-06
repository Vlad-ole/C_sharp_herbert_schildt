using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_8
    {
        static void Main(string[] args)
        {

            // Выяснить, является ли число простым. Если оно
            // непростое, вывести наибольший его множитель.

            int num;
            int i;
            int factor;
            bool isprime;
            for (num = 2; num < 20; num++)
            {
                isprime = true;
                factor = 0;
                // Выяснить, делится ли значение переменной num нацело.
                for (i = 2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {
                        // Значение переменной num делится нацело.
                        // Следовательно, это непростое число.
                        isprime = false;
                        factor = i;
                    }

                }
                if (isprime)
                    Console.WriteLine(num + " — простое число.");
                else
                    Console.WriteLine("Наибольший множитель числа " + num +
                    " равен " + factor);


            }

            Console.ReadKey();
        }
    }

}
