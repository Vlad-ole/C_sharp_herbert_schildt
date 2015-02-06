// Продемонстрировать применение директивы #elif.

#define RELEASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_16
{


    class Program_12
    {
        static void Main()
        {

        #if EXPERIMENTAL
            Console.WriteLine("Компилируется для экспериментальной версии.");
        #elif RELEASE
            Console.WriteLine("Компилируется для окончательной версии.");
        #else
            Console.WriteLine("Компилируется для внутреннего тестирования.");
        #endif


        #if TRIAL && !RELEASE
            Console.WriteLine("Пробная версия.");
        #endif
         
         Console.WriteLine("Присутствует во всех версиях.");
         
            Console.ReadKey();
        }
    }
}
