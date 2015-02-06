using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_9
    {
        static void Main(string[] args)
        {

            // Показать биты, составляющие байт.

            int t;
            byte val;
            val = 123;
            for (t = 128; t > 0; t = t / 2)
            {

                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }

            Console.ReadKey();
        }
    }
}
