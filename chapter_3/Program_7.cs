using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_7
    {
        static void Main(string[] args)
        {
            bool b;
            b = false;
            Console.WriteLine("b равно " + b);
            b = true;
            Console.WriteLine("b равно " + b);
            // Логическое значение может управлять оператором if.
            if (b) Console.WriteLine("Выполняется.");
            b = false;
            if (b) Console.WriteLine("He выполняется.");

            // Результатом выполнения оператора отношения
            // является логическое значение.
            Console.WriteLine("10 > 9 равно " + (10 > 9));

            Console.ReadKey();
        }
    }
}
