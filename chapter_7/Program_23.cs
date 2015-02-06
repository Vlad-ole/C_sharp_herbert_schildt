using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace chapter_7
{
    class Program_23
    {

        // Вывести отдельные цифры целого числа словами.
        static void Main(string[] args)
        {

            int num;
            int nextdigit;
            int numdigits;
            int[] n = new int[20];
            string[] digits = { "нуль", "один", "два",
                                "три", "четыре", "пять",
                                "шесть", "семь", "восемь",
                                "девять" 
                              };
            num = 1908;
            Console.WriteLine("Число: " + num);
            Console.Write("Число словами: ");
            nextdigit = 0;
            numdigits = 0;
            // Получить отдельные цифры и сохранить их в массиве n.

            // Эти цифры сохраняются в обратном порядке.
            do
            {
                nextdigit = num % 10;
                n[numdigits] = nextdigit;
                numdigits++;
                num = num / 10;
            } while (num > 0);
            numdigits--;
            // Вывести полученные слова.
            for (; numdigits >= 0; numdigits--)
                Console.Write(digits[n[numdigits]] + " ");
            Console.WriteLine();

           
            Console.ReadKey();

        }
    }
}
