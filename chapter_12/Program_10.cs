using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12
{
    // Скопировать структуру.

    // Определить структуру.
    struct MyStruct
    {
        public int x;
    }

    // Продемонстрировать присваивание структуры.
    class Program_10
    {
        static void Main(string[] args)
        {

            MyStruct a;
            MyStruct b;

            a.x = 10;
            b.x = 20;

            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
            
            a = b;
            b.x = 30;
            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

            Console.ReadKey();

        }
    }
}
