using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_6
{
    // Простой конструктор.

    class MyClass
    {
        public int x;
        public MyClass()
        {
            x = 10;
        }
    }


    class Program_8
    {
        static void Main()
        {
            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass();
            Console.WriteLine(t1.x + " " + t2.x);  


            Console.ReadKey();
        }
    }

}
