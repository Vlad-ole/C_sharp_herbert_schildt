﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{
    // Продемонстрировать обработку исключительной ситуации.

    class Program_1
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            
            try
            {
                Console.WriteLine("До генерирования исключения.");
                // Сгенерировать исключение в связи с выходом индекса за границы массива.
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
                }
                Console.WriteLine("He подлежит выводу");
            }
            
            catch (IndexOutOfRangeException)
            {
                // Перехватить исключение.
                Console.WriteLine("Индекс вышел за границы массива!");
            }

            Console.WriteLine("После блока перехвата исключения.");

            Console.ReadKey();

        }
    }
}
