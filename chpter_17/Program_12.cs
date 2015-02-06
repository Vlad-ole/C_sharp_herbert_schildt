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
    // Продемонстрировать применение встроенного атрибута Conditional.


    class Test
    {
        [Conditional("TRIAL")]
        void Trial()
        {
            Console.WriteLine("Пробная версия, не " + "предназначенная для распространения.");
        }

        [Conditional("RELEASE")]
        void Release()
        {
            Console.WriteLine("Окончательная рабочая версия.");
        }


        static void Main()
        {

            Test t = new Test();
            t.Trial(); //вызывается только в том случае, если
            // определен идентификатор TRIAL
            t.Release(); // вызывается только в том случае, если
            // определен идентификатор RELEASE

            Console.ReadKey();

        }

    }
}
