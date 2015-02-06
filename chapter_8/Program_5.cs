using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Передача объектов по ссылке.

    class Test
    {
        public int a, b;
        public Test(int i, int j)
        {
            a = i;
            b = j;
        }
        /* Передать объект. Теперь переменные ob.а и ob.b из объекта,
        используемого в вызове метода, будут изменены. */
        public void Change(Test ob)
        {
            ob.a = ob.a + ob.b;
            ob.b = -ob.b;
        }
    }

    class Program_5
    {
        static void Main(string[] args)
        {

            Test ob = new Test(15, 20);
            Console.WriteLine("ob.а и ob.b до вызова: " +
            ob.a + " " + ob.b);
            ob.Change(ob);
            Console.WriteLine("ob.а и ob.b после вызова: " +
            ob.a + " " + ob.b);



            Console.ReadKey();
        }
    }
}
