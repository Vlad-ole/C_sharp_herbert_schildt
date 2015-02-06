using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_16
{
    // Продемонстрировать применение директивы using.

    // Сделать видимым пространство имен Counter.
    using Counter;

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

    class Program_3
    {
        static void Main()
        {
            // Теперь класс CountDown может быть использован непосредственно.
            CountDown cd1 = new CountDown(10);
            int i;
            
            do
            {
                i = cd1.Count();
                Console.Write(i + " ");
            } while (i > 0);
            Console.WriteLine();
            CountDown cd2 = new CountDown(20);
            
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
