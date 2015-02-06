#define TRIAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace chpter_17
{
    // Продемонстрировать применение атрибута Obsolete.


    class Test
    {
        
        [Obsolete("Лучше использовать метод MyMeth2.")]
        public static int MyMeth(int a, int b)
        {
            return a / b;
        }

        // Усовершенствованный вариант метода MyMeth.
        public static int MyMeth2(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }

        static void Main()
        {

            // Для этого кода выводится предупреждение.
            Console.WriteLine("4 / 3 равно " + Test.MyMeth(4, 3));
            
            // А для этого кода предупреждение не выводится.
            Console.WriteLine("4 / 3 равно " + Test.MyMeth2(4, 3));

            Console.ReadKey();

        }

    }
}
