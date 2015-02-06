using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    // Поменять местами два значения.

    class ValueSwap
    {
        // Этот метод меняет местами свои аргументы.
        public void Swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
    }

    class Program_7
    {
        static void Main(string[] args)
        {
            ValueSwap ob = new ValueSwap();
            
            int x = 10, у = 20;
            Console.WriteLine("x и у до вызова: " + x + " " + у);
            
            ob.Swap(ref x, ref у);
            Console.WriteLine("х и у после вызова: " + x + " " + у);            


            Console.ReadKey();
        }
    }
}
