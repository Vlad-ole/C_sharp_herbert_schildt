using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_12
    {
        static void Main(string[] args)
        {

            // Отдельные части цикла for могут оставаться пустыми.

            int i;
            for (i = 0; i < 10; )
            {
                Console.WriteLine("Проход №" + i);
                i++; // инкрементировать переменную управления циклом
            }


            Console.ReadKey();
        }
    }

}
