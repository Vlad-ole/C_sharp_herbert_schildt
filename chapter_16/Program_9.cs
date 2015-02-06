#define EXPERIMENTAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение директив
// #if, #endif и #define.



namespace chapter_16
{


    class Program_9
    {
        static void Main()
        {
#if EXPERIMENTAL
            Console.WriteLine("Компилируется для экспериментальной версии.");
#endif
            Console.WriteLine("Присутствует во всех версиях.");


            Console.ReadKey();
        }
    }
}
