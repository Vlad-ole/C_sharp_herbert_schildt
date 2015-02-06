using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_16
{
    // Аддитивный характер пространств имен.

    // Сделать видимым пространство имен Counter.
    using Counter;

    // Это одно пространство имен Counter.
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

    // А это другое пространство имен Counter.
    namespace Counter
    {
        // Простой суммирующий счетчик.
        class CountUp
        {
            int val;
            int target;
            public int Target
            {
                get
                {
                    return target;
                }
            }

            public CountUp(int n)
            {
                target = n;
                val = 0;
            }

            public void Reset(int n)
            {
                target = n;
                val = 0;
            }

            public int Count()
            {
                if (val < target) return val++;
                else return target;
            }
        }
    }


    class Program_5
    {
        static void Main()
        {
            CountDown cd = new CountDown(10);
            CountUp cu = new CountUp(8);

            int i;

            do {
            i = cd.Count();
            Console.Write(i + " ");
            } while(i > 0);

            Console.WriteLine();

            //do {
            //i = cu.Count();
            //Console.Write(i + " ");
            //} while (d < cu.Target);


            Console.ReadKey();
        }
    }
}
