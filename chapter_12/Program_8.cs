using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12
{

    // Воспользоваться явной реализацией для устранения неоднозначности.

    interface IMyIF_A
    {
        int Meth(int x);
    }

    interface IMyIF_B
    {
        int Meth(int x);
    }

    // Оба интерфейса реализуются в классе MyClass.
    class MyClass : IMyIF_A, IMyIF_B
    {
        // Реализовать оба метода Meth() явно.
        int IMyIF_A.Meth(int x)
        {
            return x + x;
        }
        
        int IMyIF_B.Meth(int x)
        {
            return x * x;
        }
        
        // Вызывать метод Meth() по интерфейсной ссылке.
        public int MethA(int x)
        {
            IMyIF_A a_ob;
            a_ob = this;
            return a_ob.Meth(x); // вызов интерфейсного метода IMyIF_A
        }
        
        public int MethB(int x)
        {
            IMyIF_B b_ob;
            b_ob = this;
            return b_ob.Meth(x); // вызов интерфейсного метода IMyIF_B
        }
    }

    class Program_8
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            Console.Write("Вызов метода IMyIF_A.Meth(): ");
            Console.WriteLine(ob.MethA(3));
            Console.Write("Вызов метода IMyIF_B.Meth(): ");
            Console.WriteLine(ob.MethB(3));

            Console.ReadKey();

        }
    }
}
