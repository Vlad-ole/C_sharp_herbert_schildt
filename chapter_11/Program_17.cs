using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    /* В многоуровневой иерархии классов выполняется тот
переопределенный вариант виртуального метода,
который обнаруживается первым при продвижении
вверх по иерархии. */

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

    class Derived2 : Derived1
    {
        // В этом классе метод Who() не переопределяется.
    }

    class Derived3 : Derived2
    {
        // И в этом классе метод Who() не переопределяется.
    }


    class Program_17
    {
        static void Main(string[] args)
        {
            Derived3 dOb = new Derived3();
            Base baseRef; // ссылка на базовый класс
            baseRef = dOb;
            baseRef.Who(); // вызов метода Who() из класса Derived1


            Console.ReadKey();
        }
    }
}
