using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_8
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Число\tКвадрат\tКуб");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            Console.ReadKey();
        }
    }
}
