// Продемонстрировать применение директивы #elif.

#define RELEASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_16
{


    class Program_13
    {
        static void Main()
        {
            
            #error Это тестовая ошибка!


            Console.ReadKey();
        }
    }
}
