using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Первый пример применения делегатов, переделанный с
    // целью использовать блочные лямбда-выражения.

    // Объявить тип делегата.
    delegate string StrMod(string s);

    class Program_11
    {


        static void Main(string[] args)
        {
            // Создать делегаты, ссылающиеся на лямбда- выражения,
            // выполняющие различные операции с символьными строками.
            // Заменить пробелы дефисами.
            StrMod ReplaceSpaces = s =>
            {
                Console.WriteLine("Замена пробелов дефисами.");
                return s.Replace(' ', '-');
            };


            // Удалить пробелы.
            StrMod RemoveSpaces = s =>
            {
                string temp = "";
                int i;
                Console.WriteLine("Удаление пробелов.");
                for (i = 0; i < s.Length; i++)
                    if (s[i] != ' ') temp += s[i];
                return temp;
            };

            // Обратить строку.
            StrMod Reverse = s =>
            {
                string temp = "";
                int i, j;
                Console.WriteLine("Обращение строки.");
                for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                    temp += s[i];
                return temp;
            };

            string str;
            
            // Обратиться к лямбда-выражениям с помощью делегатов.
            StrMod strOp = ReplaceSpaces;

            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);

            Console.WriteLine();

            strOp = RemoveSpaces;
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);

            Console.WriteLine();

            strOp = Reverse;
            str = strOp("Это простой тест.");
            Console.WriteLine("Результирующая строка: " + str);


            Console.ReadKey();
        }
    }
}
