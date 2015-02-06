using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chpter_17
{
    // Продемонстрировать применение оператора is.

    class A { }
    class В : A { }

    class Program_1
    {


        static void Main(string[] args)
        {
            A a = new A();
            В b = new В();
            
            if (a is A)
                Console.WriteLine("а имеет тип A");
            
            if (b is A)
                Console.WriteLine("b совместим с А, поскольку он производный от А");
            
            if (a is В)
                Console.WriteLine("Не выводится, поскольку а не производный от В");
            
            if (b is В)
                Console.WriteLine("В имеет тип В");
            
            if (a is object)
                Console.WriteLine("а имеет тип object");

            Console.ReadKey();

        }
    }
}
