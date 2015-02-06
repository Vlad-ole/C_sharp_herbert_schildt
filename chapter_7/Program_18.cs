using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_18
    {
        

        static void Main(string[] args)
        {
            // Использовать оператор цикла foreach для обращения к двумерному массиву.

            int sum = 0;
            int[,] nums = new int[3, 5];
            
            // Задать первоначальные значения элементов массива nums.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    nums[i, j] = (i + 1) * (j + 1);
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            
            // Использовать цикл foreach для вывода значений
            // элементов массива и подсчета их суммы.
            foreach (int х in nums)
            {
                Console.WriteLine("Значение элемента равно: " + х);
                sum += х;
            }
            Console.WriteLine("Сумма равна: " + sum);

            Console.ReadKey();

        }
    }
}
