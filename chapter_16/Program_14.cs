// Продемонстрировать применение директивы #elif.

#define RELEASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_16
{


    class Program_14
    {
        static void Main()
        {

            #warning предупреждающее_сообщение

            #region abc
                Console.WriteLine("Helow!");
            #endregion abc


            Console.ReadKey();
        }
    }
}
