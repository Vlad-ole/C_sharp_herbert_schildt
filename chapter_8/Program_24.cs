using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    class Program_24
    {

        // Вывести на экран символьную строку полностью или частично.
        static void Display(string str, int start = 0, int stop = -1)
        {
            if (stop < 0)
                stop = str.Length;
            // Проверить условие выхода за заданные пределы.
            if (stop > str.Length | start > stop | start < 0)
                return;
            for (int i = start; i < stop; i++)
                Console.Write(str[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Display("это простой тест");
            Display("это простой тест", 12);
            Display("это простой тест", 4, 14);

            // Указать все аргументы по имени.
            Display(stop: 10, str: "это простой тест", start: 0);
           
            // Сделать аргумент start устанавливаемым по умолчанию.
            Display(stop: 10, str: "это простой тест");
            
            // Указать строку по позиции, аргумент stop — по имени by name,
            // тогда как аргумент start — устанавливаемым по умолчанию
            Display("это простой тест", stop: 10);


            Console.ReadKey();
        }
    }
}
