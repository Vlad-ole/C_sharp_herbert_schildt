using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Использовать модификатор доступа internal.

namespace chapter_16
{
    class InternalTest
    {
        internal int x;
    }


    class Program_15
    {
        static void Main()
        {
            InternalTest ob = new InternalTest();
            ob.x = 10; // доступно, потому что находится в том же файле
            Console.WriteLine("Значение ob.x: " + ob.x);

            Console.ReadKey();
        }
    }
}
