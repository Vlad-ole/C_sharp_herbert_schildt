using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_4
    {
        static void Main(string[] args)
        {

            // Продемонстрировать применение оператора switch.

            int i;
            for (i = 0; i < 10; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine("i равно нулю");
                        break;
                    case 1:
                        Console.WriteLine("i равно единице");
                        break;
                    case 2:
                        Console.WriteLine("i равно двум");
                        break;
                    case 3:
                        Console.WriteLine("i равно трем");
                        break;
                    case 4:
                        Console.WriteLine("i равно четырем");
                        break;
                    default:
                        Console.WriteLine("i равно или больше пяти");
                        break;
                }

            Console.ReadKey();
        }
    }
}
