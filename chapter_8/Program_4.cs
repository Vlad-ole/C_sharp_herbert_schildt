using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    // Передача аргументов обычных типов по значению.

    class Test
    {
        /* Этот метод не оказывает никакого влияния на
        аргументы, используемые для его вызова. */
        public void NoChange(int i, int j)
        {
            i = i + j;
            j = -j;
        }
    }
    
    class Program_4
    {
        static void Main(string[] args)
        {

            Test ob = new Test();
            int a = 15, b = 20;
            Console.WriteLine("а и b до вызова: " +
            a + " " + b);
            ob.NoChange(a, b);
            Console.WriteLine("а и b после вызова: " +
            a + " " + b);


            Console.ReadKey();
        }
    }
}
