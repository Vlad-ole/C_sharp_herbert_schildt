using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_18
    {
        static void Main(string[] args)
        {
            // *** Эта программа не может быть скомпилирована. ***

            long L;
            double D;
            D = 100123285.0;
            L = D; // Недопустимо!!!
            Console.WriteLine("L и D: " + L + " " + D);

            Console.ReadKey();
        }
    }
}
