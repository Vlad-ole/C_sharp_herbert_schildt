using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_16
{
    // Продемонстрировать применение псевдонима.

    // Создать псевдоним для составного имени Counter.CountDown.
    using MyCounter = Counter.CountDown;

    // Объявить пространство имен для счетчиков.
    namespace Counter
    {
        // Простой вычитающий счетчик.
        class CountDown
        {
            int val;
            public CountDown(int n)
            {
                val = n;
            }
            public void Reset(int n)
            {
                val = n;
            }
            public int Count()
            {
                if (val > 0) return val--;
                else return 0;
            }
        }
    }

    class Program_4
    {
        static void Main()
        {

            // Здесь и далее псевдоним MyCounter используется
            // вместо составного имени Counter.CountDown.

            MyCounter cd1 = new MyCounter(10);
            int i;
            
            do
            {
                i = cd1.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            MyCounter cd2 = new MyCounter(20);
            
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            cd2.Reset(4);
            
            do
            {
                i = cd2.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
