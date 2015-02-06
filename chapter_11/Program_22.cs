using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Пример упаковки при передаче значения методу.

    class Program_22
    {

        static int Sqr(object о)
        {
            return (int)о * (int)о;
        }

        static void Main(string[] args)
        {
            int x;
            x = 10;
            Console.WriteLine("Значение x равно: " + x);
            // значение переменной x автоматически упаковывается
            // когда оно передается методу Sqr().
            x = Program_22.Sqr(x);
            Console.WriteLine("Значение x в квадрате равно: " + x);
            Console.ReadKey();

        }

        
    }
}
