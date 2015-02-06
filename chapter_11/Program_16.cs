using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    /* Если виртуальный метод не переопределяется, то
используется его вариант из базового класса. */

    class Base
    {
        // Создать виртуальный метод в базовом классе.
        public virtual void Who()
        {
            Console.WriteLine("Метод Who() в классе Base");
        }
    }
    
    class Derived1 : Base
    {
        // Переопределить метод Who() в производном классе.
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derived1");
        }
    }
    
    class Derived2 : Base
    {
        // В этом классе метод Who() не переопределяется.
    }


    class Program_16
    {
        static void Main(string[] args)
        {

            Base baseOb = new Base();
            Derived1 dOb1 = new Derived1();
            Derived2 dOb2 = new Derived2();
            Base baseRef; // ссылка на базовый класс
            baseRef = baseOb;
            baseRef.Who();
            baseRef = dOb1;
            baseRef.Who();
            baseRef = dOb2;
            baseRef.Who(); // вызывается метод Who() из класса Base


            Console.ReadKey();
        }
    }
}
