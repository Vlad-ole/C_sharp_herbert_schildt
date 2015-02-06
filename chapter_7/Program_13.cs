﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_13
    {


        static void Main(string[] args)
        {

            // Продемонстрировать применение свойства Length
            // при обращении со ступенчатыми массивами.

            int[][] network_nodes = new int[4][];
            network_nodes[0] = new int[3];
            network_nodes[1] = new int[7];
            network_nodes[2] = new int[2];
            network_nodes[3] = new int[5];


            int i, j;

            // Сфабриковать данные об использовании ЦП.
            for (i = 0; i < network_nodes.Length; i++)
                for (j = 0; j < network_nodes[i].Length; j++)
                    network_nodes[i][j] = i * j + 70;
            Console.WriteLine("Общее количество узлов сети: " +
            network_nodes.Length + "\n");
            
            for (i = 0; i < network_nodes.Length; i++)
            {
                for (j = 0; j < network_nodes[i].Length; j++)
                {
                    Console.Write("Использование в узле сети " + i +
                    " ЦП " + j + ": ");
                    Console.Write(network_nodes[i][j] + "% ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
