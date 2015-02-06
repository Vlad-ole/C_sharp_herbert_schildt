using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12.Program_1
{
    // Использовать интерфейс ISeries для реализации
    // процесса генерирования простых чисел.

    class Primes : ISeries
    {
        int start;
        int val;
        public Primes()
        {
            start = 2;
            val = 2;
        }
        public int GetNext()
        {
            int i, j;
            bool isprime;
            val++;
            for (i = val; i < 1000000; i++)
            {
                isprime = true;
                for (j = 2; j <= i / j; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    val = i;
                    break;
                }
            }
            return val;
        }

        public void Reset()
        {
            val = start;
        }
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
}

