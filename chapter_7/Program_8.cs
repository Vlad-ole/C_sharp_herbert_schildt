﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_8
    {
    

        static void Main(string[] args)
        {

            // Продемонстрировать применение ступенчатых массивов.

            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
            int i;
           

           // Сохранить значения в первом массиве.
            for (i = 0; i < 4; i++)
                jagged[0][i] = i;
           
            // Сохранить значения во втором массиве.
            for (i = 0; i < 3; i++)
                jagged[1][i] = i;

            for (i = 0; i < 5; i++)
                jagged[2][i] = i;
            
            // Вывести значения из первого массива.
            for (i = 0; i < 4; i++)
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
           
            // Вывести значения из второго массива.
            for (i = 0; i < 3; i++)
                Console.Write(jagged[1][i] + " ");
            Console.WriteLine();
            
            // Вывести значения из третьего массива.
            for (i = 0; i < 5; i++)
                Console.Write(jagged[2][i] + " ");
            Console.WriteLine();



            Console.ReadKey();

        }
    }
}
