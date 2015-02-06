using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_1
    {
        // Продемонстрировать одномерный массив.
        
        static void Main(string[] args)
        {

            int[] sample = new int[10];
            int i;
            for (i = 0; i < 10; i = i + 1)
                sample[i] = i;
            for (i = 0; i < 10; i = i + 1)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);

            Console.ReadKey();

        }
    }
}
