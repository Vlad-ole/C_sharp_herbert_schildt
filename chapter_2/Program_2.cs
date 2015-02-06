using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            int x; // здесь объявляется переменная
            int у; // здесь объявляется еще одна переменная
            x = 100; // здесь переменной х присваивается значение 100
            Console.WriteLine("х содержит " + x);
            у = x / 2;
            Console.Write("у содержит х / 2: ");
            Console.WriteLine(у);
            Console.ReadKey();
        }
    }
}
