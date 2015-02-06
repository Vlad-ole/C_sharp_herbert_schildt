using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace chapter_8
{
    // Применить статический конструктор.

    class Cons
    {
        public static int alpha;
        public int beta;
        // Статический конструктор.
        static Cons()
        {
            alpha = 99;
            Console.WriteLine("В статическом конструкторе.");
        }
        // Конструктор экземпляра.
        public Cons()
        {
            beta = 100;
            Console.WriteLine("В конструкторе экземпляра.");
        }
    }

    class Program_33
    {


        static void Main(string[] args)
        {
            Cons ob = new Cons();
            Console.WriteLine("Cons.alpha: " + Cons.alpha);
            Console.WriteLine("ob.beta: " + ob.beta);

            Console.ReadKey();
        }
    }
}
