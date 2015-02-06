using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{

    // Использовать вложенный блок try.

    class Program_8
    {
        static void Main(string[] args)
        {

            // Здесь массив numer длиннее массива denom.
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };

            // внешний блок try
            try
            {
                for (int i = 0; i < numer.Length; i++)
                {
                    try
                    { // вложенный блок try
                        Console.WriteLine(numer[i] + " / " +
                        denom[i] + " равно " +
                        numer[i] / denom[i]);
                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Делить на нуль нельзя!");

                    }
                }

            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Подходящий элемент не найден.");
                Console.WriteLine("Неисправимая ошибка - программа прервана.");
            }


            Console.ReadKey();
        }
    }
}
