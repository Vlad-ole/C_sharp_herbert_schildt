using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_16
{
    // Вложенные пространства имен.

    namespace NS1
    {
        class ClassA
        {
            public ClassA()
            {
                Console.WriteLine("Конструирование класса ClassA");
            }
        }

        namespace NS2
        { // вложенное пространство имен
            class ClassB
            {
                public ClassB()
                {
                    Console.WriteLine("Конструирование класса ClassB");
                }
            }
        }
    }

    class Program_6
    {
        static void Main()
        {
            NS1.ClassA a = new NS1.ClassA();
            
            // NS2.ClassB b = new NS2.ClassB(); // Неверно!!! Пространство NS2 невидимо
            
            NS1.NS2.ClassB b = new NS1.NS2.ClassB(); // Верно!

            Console.ReadKey();
        }
    }
}
