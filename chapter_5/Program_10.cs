using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_10
    {
        static void Main(string[] args)
        {

            // Использовать запятые в операторе цикла for для
            // выявления наименьшего и наибольшего множителя числа.

            int i, j;
            int smallest, largest;
            int num;
            num = 100;
            smallest = largest = 1;
            for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
            {
                if ((smallest == 1) & ((num % i) == 0))
                    smallest = i;
                if ((largest == 1) & ((num % j) == 0))
                    largest = j;
            }
            Console.WriteLine("Наибольший множитель: " + largest);
            Console.WriteLine("Наименьший множитель: " + smallest);

            Console.ReadKey();
        }
    }

}
