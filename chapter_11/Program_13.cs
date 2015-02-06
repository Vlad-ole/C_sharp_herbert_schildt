using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{
    // По ссылке на объект базового класса можно обращаться
    // к объекту производного класса.

    class X
    {
        public int a;
        public X(int i)
        {
            a = i;
        }
    }

    class Y : X
    {
        public int b;
        public Y(int i, int j): base(j)
        {
            b = i;
        }
    }

    class Program_13
    {
        static void Main(string[] args)
        {
            X x = new X(10);
            X x2;
            
            Y y = new Y(5, 6);
            Y y2;
            
            x2 = x; // верно, поскольку оба объекта относятся к одному и тому же типу
            Console.WriteLine("х2.а: " + x2.a);
            
            x2 = y; // тоже верно, поскольку класс Y является производным от класса X            
            Console.WriteLine("х2.а: " + x2.a);
            
            // ссылкам на объекты класса X известно только о членах класса X
            x2.a = 19; // верно
            // х2.b = 27; // неверно, поскольку член b отсутствует у класса X

            

            Console.ReadKey();
        }
    }
}
