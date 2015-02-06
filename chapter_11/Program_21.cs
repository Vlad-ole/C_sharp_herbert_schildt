using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Простой пример упаковки и распаковки.



    class Program_21
    {
        static void Main(string[] args)
        {

            int x;
            object obj;

            x = 10;
            obj = x; // упаковать значение переменной х в объект
            int у = (int)obj; // распаковать значение из объекта, доступного по
            // ссылке obj, в переменную типа int
            Console.WriteLine(у);

            Console.ReadKey();
        }
    }
}
