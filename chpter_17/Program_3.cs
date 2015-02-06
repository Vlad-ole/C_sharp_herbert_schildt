using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chpter_17
{

    // Продемонстрировать применение оператора as.

    class A { }
    class В : A { }

    class Program_3
    {


        static void Main(string[] args)
        {
            A a = new A();
            В b = new В();
           
            b = a as В; // выполнить приведение типов, если это возможно
            
            if (b == null)
                Console.WriteLine("Приведение типов b = (В) НЕ допустимо.");
            else
                Console.WriteLine("Приведение типов b = (В) допустимо.");

            Console.ReadKey();

        }
    }
}
