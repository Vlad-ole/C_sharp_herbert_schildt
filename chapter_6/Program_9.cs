using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_6
{

    // Параметризированный конструктор.

    class MyClass
    {
        public int x;
        public MyClass(int i)
        {
            x = i;
        }
    }


    class Program_9
    {
        static void Main()
        {

            MyClass t1 = new MyClass(10);
            MyClass t2 = new MyClass(88);
            Console.WriteLine(t1.x + " " + t2.x);

            Console.ReadKey();
        }
    }

}
