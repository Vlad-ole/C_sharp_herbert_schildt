using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_20
    {
        static void Main(string[] args)
        {

            // Применить оператор break для выхода из цикла do-while.

            int i;
            i = -10;
            do
            {
                if (i > 0) break;
                Console.Write(i + " ");
                i++;
            } while (i <= 10);
            Console.WriteLine("Готово!");
            
            Console.ReadKey();
        }
    }

}
