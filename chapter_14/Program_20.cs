using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{
    // Применить методы Exists() и GetLastAccessTime().

    class Program_20
    {
        static void Main(string[] args)
        {
            if (File.Exists("test.txt"))
            {
                Console.WriteLine("Файл существует. В последний раз он был доступен " + File.GetLastAccessTime("test.txt"));
                Console.WriteLine("Время последней записи в файл " + File.GetLastWriteTime("test.txt"));
                Console.WriteLine("Время создания файла " + File.GetCreationTime("test.txt"));
            }

            else
                Console.WriteLine("Файл не существует");


            Console.ReadKey();
        }
    }
}
