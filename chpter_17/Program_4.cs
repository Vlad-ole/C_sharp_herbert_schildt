using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chpter_17
{
    // Продемонстрировать применение оператора typeof.

    class Program_4
    {


        static void Main(string[] args)
        {
            Type t = typeof(StreamReader);
            Console.WriteLine(t.FullName);
            if (t.IsClass) Console.WriteLine("Относится к классу.");
            if (t.IsAbstract) Console.WriteLine("Является абстрактным классом.");
            else Console.WriteLine("Является конкретным классом.");

            Console.ReadKey();

        }
    }
}
