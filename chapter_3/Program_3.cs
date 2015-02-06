using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_3
    {
        static void Main(string[] args)
        {
            double r;
            Double area;
            area = 10.0;
            r = Math.Sqrt(area / 3.1416);
            Console.WriteLine("Радиус равен " + r);

            Console.ReadKey();
        }
    }
}
