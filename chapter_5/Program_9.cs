using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_9
    {
        static void Main(string[] args)
        {

            // Использовать запятые в операторе цикла for.

            int i, j;
            for (i = 0, j = 10; i < j; i++, j--)
                Console.WriteLine("i и j: " + i + " " + j);

            Console.ReadKey();
        }
    }

}
