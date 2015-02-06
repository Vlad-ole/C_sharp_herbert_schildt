using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_11
    {
    

        static void Main(string[] args)
        {

            // Использовать свойство Length трехмерного массива.

            int[, ,] nums = new int[10, 5, 6];
            Console.WriteLine("Длина массива nums равна " + nums.Length);

            Console.ReadKey();

        }
    }
}
