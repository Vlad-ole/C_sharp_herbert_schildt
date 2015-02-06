using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{

    // Изящно обработать исключительную ситуацию и продолжить выполнение программы.

    class Program_5
    {
        static void Main(string[] args)
        {
            int[] numer = { 4, 8, 16, 32, 64, 128 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " +
                    denom[i] + " равно " +
                    numer[i] / denom[i]);
                }
                
                catch (DivideByZeroException)
                {
                    // Перехватить исключение.
                    Console.WriteLine("Делить на нуль нельзя!");
                }
            }


            Console.ReadKey();

        }
    }
}
