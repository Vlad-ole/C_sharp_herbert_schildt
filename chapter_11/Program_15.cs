using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{
    // Продемонстрировать виртуальный метод.

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
            Console.WriteLine("Метод Who() в классе Derivedl");
        }
    }

    class Derived2 : Base
    {
        // Вновь переопределить метод Who() в еще одном производном классе.
        public override void Who()
        {
            Console.WriteLine("Метод Who() в классе Derived2");
        }
    }


    class Program_15
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
            baseRef.Who();


            Console.ReadKey();
        }
    }
}
