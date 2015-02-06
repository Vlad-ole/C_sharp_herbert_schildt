using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    // Использовать два параметра типа out.

    class Num
    {
        /* Определить, имеется ли у числовых значений переменных х и v
        общий множитель. Если имеется, то возвратить наименьший и
        наибольший множители посредством параметров типа out. */
        public bool HasComFactor(int x, int y, out int least, out int greatest)
        {
            int i;
            int max = x < y ? x : y;
            bool first = true;
            least = 1;
            greatest = 1;
            // Найти наименьший и наибольший общий множитель.
            for (i = 2; i <= max / 2 + 1; i++)
            {
                if (((y % i) == 0) & ((x % i) == 0))
                {
                    if (first)
                    {
                        least = i;
                        first = false;
                    }
                    greatest = i;
                }
            }
            if (least != 1) return true;
            else return false;
        }
    }

    class Program_9
    {
        static void Main(string[] args)
        {
            Num ob = new Num();
            int lcf, gcf;
            if (ob.HasComFactor(231, 105, out lcf, out gcf))
            {
                Console.WriteLine("Наименьший общий множитель " +
            "чисел 231 и 105 равен " + lcf);
                Console.WriteLine("Наибольший общий множитель " +
                "чисел 231 и 105 равен " + gcf);
            }
            else
                Console.WriteLine("Общий множитель у чисел 35 и 49 отсутствует.");

            

            if (ob.HasComFactor(35, 51, out lcf, out gcf))
            {
                Console.WriteLine("Наименьший общий множитель " +
                "чисел 35 и 51 равен " + lcf);
                Console.WriteLine("Наибольший общий множитель " +
                "чисел 35 и 51 равен " + gcf);
            }
            else
                Console.WriteLine("Общий множитель у чисел 35 и 51 отсутствует.");

            
            Console.ReadKey();
        }
    }
}
