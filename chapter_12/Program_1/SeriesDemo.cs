using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12.Program_1
{
    // Продемонстрировать применение класса ByTwos, реализующего интерфейс.

    class SeriesDemo
    {
        static void Main(string[] args)
        {
            ByTwos ob = new ByTwos();
            
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());
            
            Console.WriteLine("\nСбросить");
            ob.Reset();
            
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());
           
            Console.WriteLine("\nНачать с числа 100");
            ob.SetStart(100);
            
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.GetNext());

            Console.ReadKey();

        }
    }
}
