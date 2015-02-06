using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{

    // Сгенерировать исключение вручную.

    class Program_9
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("До генерирования исключения.");
                throw new DivideByZeroException();
            }
            
            catch (DivideByZeroException)
            {
                Console.WriteLine("Исключение перехвачено.");
            }

            Console.WriteLine("После пары операторов try/catch.");


            Console.ReadKey();
        }
    }
}
