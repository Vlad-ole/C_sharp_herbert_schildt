using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chpter_17
{
    // Использовать оператор is для предотвращения неправильного приведения типов.

    class A { }
    class В : A { }

    class Program_2
    {


        static void Main(string[] args)
        {
            A a = new A();
            В b = new В();
            
            // Проверить, можно ли привести а к типу В.
            if (a is В) // если да, то выполнить приведение типов
                b = (В)a;
            else // если нет, то пропустить приведение типов
                b = null;
            
            if (b == null)
                Console.WriteLine("Приведение типов b = (В) HE допустимо.");
            else
                Console.WriteLine("Приведение типов b = (В) допустимо.");
                      

            Console.ReadKey();

        }
    }
}
