using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    // Использовать фабрику класса.

    class MyClass
    {
        int a, b; // закрытые члены класса
        // Создать фабрику для класса MyClass.
        public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;
            return t; // возвратить объект
        }
        public void Show()
        {
            Console.WriteLine("а и b: " + a + " " + b);
        }
    }

    class Program_14
    {
        static void Main(string[] args)
        {

            MyClass ob = new MyClass();
            int i, j;
            // Сформировать объекты, используя фабрику класса.
            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = ob.Factory(i, j); // создать объект
                anotherOb.Show();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
