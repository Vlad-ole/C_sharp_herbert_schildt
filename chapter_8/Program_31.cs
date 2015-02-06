using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace chapter_8
{

    // Использовать поле типа static для подсчета
    // экземпляров существующих объектов.

    class CountInst
    {
        
        static int count = 0;
        
        // Инкрементировать подсчет, когда создается объект.
        public CountInst()
        {
            count++;
        }
        
        // Декрементировать подсчет, когда уничтожается объект.
        ~CountInst()
        {
            count--;
        }
        
        public static int GetCount()
        {
            return count;
        }
    }

    class Program_31
    {

        static void Main(string[] args)
        {

            CountInst ob;
            for (int i = 0; i < 10; i++)
            {
                ob = new CountInst();
                Console.WriteLine("Текущий подсчет: " + CountInst.GetCount());
            }


            Console.ReadKey();
        }
    }
}
