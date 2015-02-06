﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{

    // Использовать несколько операторов catch.

    class Program_6
    {
        static void Main(string[] args)
        {
            // Здесь массив numer длиннее массива denom.
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            
            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                }
                
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на нуль нельзя!");
                }
                
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Подходящий элемент не найден.");
                }
            }


            Console.ReadKey();

        }
    }
}
