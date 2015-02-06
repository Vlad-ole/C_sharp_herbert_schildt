using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
    class Program_6
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 0; count < 5; count = count + 1)
                Console.WriteLine("Это подсчет: " + count);
            Console.WriteLine("Готово!");

            Console.ReadKey();
        }
    }
}
