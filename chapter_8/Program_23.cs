using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    // Продемонстрировать необязательные аргументы.

    class OptionArgDemo
    {
        public static void OptArgMeth(int alpha, int beta = 10, int gamma = 20)
        {
            Console.WriteLine("Это аргументы alpha, beta и gamma: " +
            alpha + " " + beta + " " + gamma);
        }
    }

    class Program_23
    {
        static void Main(string[] args)
        {
            OptionArgDemo.OptArgMeth(1, 2, 3);
            OptionArgDemo.OptArgMeth(1, 2);
            OptionArgDemo.OptArgMeth(1);
                       

            Console.ReadKey();
        }
    }
}
