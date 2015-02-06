﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{
    // Использовать блок finally.

    class UseFinally
    {
        public static void GenException(int what)
        {
            int t;
            int[] nums = new int[2];
            
            Console.WriteLine("Получить " + what);
            try
            {
                switch (what)
                {
                    case 0:
                        t = 10 / what; // сгенерировать ошибку из-за деления на нуль
                        break;
                    case 1:
                        nums[4] = 4; // сгенерировать ошибку индексирования массива
                        break;
                    case 2:
                        return; // возврат из блока try
                }
            }

            
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на нуль нельзя!");
                return; // возврат из блока catch
            }
            
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Совпадающий элемент не найден.");
            }
            
            finally
            {
                Console.WriteLine("После выхода из блока try.");
            }
        }
    }
    

    class Program_11
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                UseFinally.GenException(i);
                Console.WriteLine();
            }
           

            Console.ReadKey();
        }
    }
}
