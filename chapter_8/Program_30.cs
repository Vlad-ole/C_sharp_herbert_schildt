using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace chapter_8
{
    // Использовать модификатор static.

    class StaticDemo
    {
        // Переменная типа static.
        public static int Val = 100;

        // Метод типа static.
        public static int ValDiv2()
        {
            return Val / 2;
        }
    }

    class MyClass
    {
        // Нестатический метод.
        void NonStaticMeth()
        {
            Console.WriteLine("В методе NonStaticMeth().");
        }
        
        /* Нестатический метод может быть вызван из
        статического метода по ссылке на объект. */
        public static void staticMeth(MyClass ob)
        {
            ob.NonStaticMeth(); // все верно!
        }
    }


    class Program_30
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Исходное значение переменной " + "StaticDemo.Val равно " + StaticDemo.Val);
            StaticDemo.Val = 8;
            Console.WriteLine("Текущее значение переменной" + "StaticDemo.Val равно " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());


            Console.ReadKey();
        }
    }
}
