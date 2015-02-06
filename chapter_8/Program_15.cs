using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Возвратить массив из метода.

    class Factor
    {
        /* Метод возвращает массив facts, содержащий множители аргумента num.
        При возврате из метода параметр numfactors типа out будет содержать
        количество обнаруженных множителей. */
        public int[] FindFactors(int num, out int numfactors)
        {
            int[] facts = new int[80]; // размер массива 80 выбран произвольно
            int i, j;
            // Найти множители и поместить их в массив facts.
            for (i = 2, j = 0; i < num / 2 + 1; i++)
                if ((num % i) == 0)
                {
                    facts[j] = i;
                    j++;
                }
            numfactors = j;
            return facts;
        }
    }

    class Program_15
    {
        static void Main(string[] args)
        {
            Factor f = new Factor();
            int numfastors;
            int[] factors;

            factors = f.FindFactors(1000, out numfastors);

            Console.WriteLine("Множители числа 1000: ");
            for (int i = 0; i < numfastors; i++)
                Console.Write(factors[i] + " ");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
