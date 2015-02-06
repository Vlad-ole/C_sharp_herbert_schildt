using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Простой пример применения делегата.

    // Объявить тип делегата.
    delegate string StrMod(string str);

    class Program_1
    {

        // Заменить пробелы дефисами.
        static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Замена пробелов дефисами.");
            return s.Replace(' ', '-');
        }

        // Удалить пробелы.
        static string RemoveSpaces(string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Удаление пробелов.");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];

            return temp;
        }

        // Обратить строку.
        static string Reverse(string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Обращение строки.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }

        static void Main(string[] args)
        {
            // Сконструировать делегат.
            StrMod strOp = new StrMod(ReplaceSpaces);
           
            string str;
            
            // Вызвать методы с помощью делегата.
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);
            
            Console.WriteLine();
            
            strOp = new StrMod(RemoveSpaces);
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);
            
            Console.WriteLine();
            
            strOp = new StrMod(Reverse);
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);

            strOp = ReplaceSpaces; // использовать групповое преобразование методов

            Console.ReadKey();
        }
    }
}
