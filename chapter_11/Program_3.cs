using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{
    class В
    {
        protected int i, j; // члены, закрытые для класса В,
        // но доступные для класса D
        public void Set(int a, int b)
        {
            i = a;
            j = b;
        }
        public void Show()
        {
            Console.WriteLine(i + " " + j);
        }
    }

    class D : В
    {
        int k; // закрытый член
        // члены i и j класса В доступны для класса D
        public void Setk()
        {
            k = i * j;
        }
        public void Showk()
        {
            Console.WriteLine(k);
        }
    }



    class Program_3
    {
        static void Main(string[] args)
        {

            D ob = new D();
            ob.Set(2, 3); // допустимо, поскольку доступно для класса D

            ob.Show(); // допустимо, поскольку доступно для класса D
            ob.Setk(); // допустимо, поскольку входит в класс D
            ob.Showk(); // допустимо, поскольку входит в класс D

            Console.ReadKey();
        }
    }
}
