using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_4
    {
        

        static void Main(string[] args)
        {

            // Продемонстрировать превышение границ массива.

            int[] sample = new int[10];
            int i;
            // Воссоздать превышение границ массива.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;


            Console.ReadKey();

        }
    }
}
