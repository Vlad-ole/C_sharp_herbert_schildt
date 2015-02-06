using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_25
    {
        static void Main(string[] args)
        {

            // Продемонстрировать практическое применение оператора goto.

            int i = 0, j = 0, k = 0;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine("i, j, k: " + i + " " + j +
                        " " + k);
                        if (k == 3) goto stop;
                    }
                }
            }
        stop:
            Console.WriteLine("Остановлено! i, j, k: " + i +
            ", " + j + " " + k);

            Console.ReadKey();
        }
    }

}
