using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_21
    {
        static void Main(string[] args)
        {

            // Выявить наименьший множитель числа.

            int factor = 1;
            int num = -1000;
            for (int i = 2; i <= num / i; i++)
            {
                if ((num % i) == 0)
                {
                    factor = i;
                    break; // прервать цикл, как только будет
                    // выявлен наименьший множитель числа
                }
            }
            Console.WriteLine("Наименьший множитель равен " + factor);

            Console.ReadKey();
        }
    }

}
