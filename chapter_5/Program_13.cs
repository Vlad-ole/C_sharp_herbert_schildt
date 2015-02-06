using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_13
    {
        static void Main(string[] args)
        {

            // Исключить еще одну часть из определения цикла for.

            int i;
            i = 0; // исключить инициализацию из определения цикла
            for (; i < 10; )
            {
                Console.WriteLine("Проход №" + i);

                i++; // инкрементировать переменную управления циклом
            }

            Console.ReadKey();
        }
    }

}
