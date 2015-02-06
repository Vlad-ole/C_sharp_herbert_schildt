// Использовать идентификаторное выражение.

#define EXPERIMENTAL
#define TRIAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_16
{


    class Program_10
    {
        static void Main()
        {
            #if EXPERIMENTAL
            Console.WriteLine("Компилируется для экспериментальной версии.");
            #endif

            #if EXPERIMENTAL && TRIAL
            Console.Error.WriteLine("Проверка пробной экспериментальной версии.");
            #endif

            Console.WriteLine("Присутствует во всех версиях.");

            Console.ReadKey();
        }
    }
}
