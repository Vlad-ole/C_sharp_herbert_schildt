﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Продемонстрировать групповую адресацию.

    // Объявить тип делегата.
    delegate void StrMod(ref string str);


    class Program_3
    {
        // Заменить пробелы дефисами.
        static void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            s = s.Replace(' ', '-');
        }

        // Удалить пробелы.
        static void RemoveSpaces(ref string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Удаление пробелов.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            s = temp;
        }

        // Обратить строку.
        static void Reverse(ref string s)
        {
            string temp = "";
            int i, j;

            Console.WriteLine("Обращение строки.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            s = temp;
        }

        static void Main(string[] args)
        {
            // Сконструировать делегаты.
            StrMod strOp;
            StrMod replaceSp = ReplaceSpaces;
            StrMod removeSp = RemoveSpaces;
            StrMod reverseStr = Reverse;

            string str = "Это простой тест.";

            // Организовать групповую адресацию.
            strOp = replaceSp;
            strOp += reverseStr;

            // Обратиться к делегату с групповой адресацией.
            strOp(ref str);
            Console.WriteLine("Результирующая строка: " + str);
            Console.WriteLine();

            // Удалить метод замены пробелов и добавить метод удаления пробелов.
            strOp -= replaceSp;
            strOp += removeSp;
            str = "Это простой тест."; // восстановить исходную строку

            // Обратиться к делегату с групповой адресацией.
            strOp(ref str);
            Console.WriteLine("Результирующая строка: " + str);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
