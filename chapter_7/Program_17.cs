using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_17
    {
        

        static void Main(string[] args)
        {

           // Использовать оператор break для преждевременного завершения цикла foreach.
            int sum = 0;
            int[] nums = new int[10];
            
            
            // Задать первоначальные значения элементов массива nums.
            for (int i = 0; i < 10; i++)
                nums[i] = i;
            
            
            // Использовать цикл foreach для вывода значений
            // элементов массива и подсчета их суммы.
            foreach (int x in nums)
            {
                Console.WriteLine("Значение элемента равно: " + x);
                sum += x;
                if (x == 4) break; // прервать цикл, как только индекс массива достигнет 4
            }
            Console.WriteLine("Сумма первых 5 элементов: " + sum);

            Console.ReadKey();

        }
    }
}
