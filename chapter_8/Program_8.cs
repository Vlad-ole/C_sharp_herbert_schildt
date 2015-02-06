using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Использовать модификатор параметра out.

    class Decompose
    {
        /* Разделить числовое значение с плавающей точкой на
        целую и дробную части. */
        public int GetParts(double n, out double frac)
        {
            int whole;
            whole = (int)n;
            frac = n - whole; // передать дробную часть числа через параметр frac
            return whole; // возвратить целую часть числа
        }
    }
    
    
    class Program_8
    {
        static void Main(string[] args)
        {

            Decompose ob = new Decompose();
            int i;
            double f;
            i = ob.GetParts(10.125, out f);
            Console.WriteLine("Целая часть числа равна " + i);
            Console.WriteLine("Дробная часть числа равна " + f);


            Console.ReadKey();
        }
    }
}
