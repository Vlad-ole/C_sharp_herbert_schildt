using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_16.Program_1
{
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
}
