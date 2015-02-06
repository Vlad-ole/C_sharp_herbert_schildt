using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_20
    {
        static void Main(string[] args)
        {

            // Пример неожиданного результата продвижения типов!

            byte b;
            b = 10;

            b = (byte)(b * b); // Необходимо приведение типов!!
            Console.WriteLine("b: " + b);


            char ch1 = 'a', ch2 = 'b';
            ch1 = (char)(ch1 + ch2);

            Console.ReadKey();
        }
    }
}
