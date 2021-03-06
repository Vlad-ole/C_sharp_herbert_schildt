﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    // Объявить тип делегата.
    delegate void CountIt();

    class Program_5
    {


        static void Main(string[] args)
        {

            // Далее следует код для подсчета чисел, передаваемый делегату
            // в качестве анонимного метода.
            CountIt count = delegate
            {
                // Этот кодовый блок передается делегату.
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);
            }; // обратите внимание на точку с запятой
            
            count();

            Console.ReadKey();
        }
    }
}
