using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Эта программа не подлежит компиляции.

    class X
    {
        int a;
        public X(int i) { a = i; }
    }

    class Y
    {
        int a;
        public Y(int i) { a = i; }
    }
    
    class Program_12
    {
        static void Main(string[] args)
        {
            X x = new X(10);
            X x2;
            
            Y y = new Y(5);
            
            x2 = x; // верно, поскольку оба объекта относятся к одному и тому же типу
            x2 = y; // ошибка, поскольку это разнотипные объекты

            Console.ReadKey();
        }
    }
}
