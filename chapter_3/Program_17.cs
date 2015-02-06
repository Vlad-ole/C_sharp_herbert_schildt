using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_17
    {
        static void Main(string[] args)
        {
            // Продемонстрировать неявное преобразование типа long в тип double.

            long L;
            double D;
            L = 100123285L;
            D = L;
            Console.WriteLine("L и D: " + L + " " + D);


            Console.ReadKey();
        }
    }
}
