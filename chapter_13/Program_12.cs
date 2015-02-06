using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{

    // Использовать члены класса Exception.

    class ExcTest
    {
        public static void GenException()
        {
            int[] nums = new int[4];
            Console.WriteLine("До генерирования исключения.");
            // Сгенерировать исключение в связи с выходом за границы массива.
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: (1)", i, nums[i]);
            }

            Console.WriteLine("He подлежит выводу");
        }
    }

    class Program_12
    {
        static void Main(string[] args)
        {
            try
            {
                ExcTest.GenException();
            }

            catch (IndexOutOfRangeException exc)
            {
                Console.WriteLine("Стандартное сообщение таково: ");
                Console.WriteLine();
                Console.WriteLine(exc); // вызвать метод ToString()
                Console.WriteLine();
                Console.WriteLine("Свойство StackTrace: " + exc.StackTrace);
                Console.WriteLine();
                Console.WriteLine("Свойство Message: " + exc.Message);
                Console.WriteLine();
                Console.WriteLine("Свойство TargetSite: " + exc.TargetSite);
                Console.WriteLine();
            }
            Console.WriteLine("После блока перехвата исключения.");
           

            Console.ReadKey();
        }
    }
}
