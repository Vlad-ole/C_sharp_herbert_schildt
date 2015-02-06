﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Использовать класс object для создания массива "обобщенного" типа.
    class Program_24
    {


        static void Main(string[] args)
        {
            object[] ga = new object[10];
            
            // Сохранить целые значения.
            for (int i = 0; i < 3; i++)
                ga[i] = i;
            
            // Сохранить значения типа double.
            for (int i = 3; i < 6; i++)
                ga[i] = (double)i / 2;
            
            // Сохранить две строки, а также значения типа bool и char.
            ga[6] = "Привет";
            ga[7] = true;
            ga[8] = 'X';
            ga[9] = "Конец";

            for (int i = 0; i < ga.Length; i++)
                Console.WriteLine("ga[" + i + "]: " + ga[i] + " ");


            Console.ReadKey();

        }
    }
}
