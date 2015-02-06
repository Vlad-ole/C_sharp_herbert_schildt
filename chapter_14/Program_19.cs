using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{

    /* Скопировать файл, используя метод File.Copy().
    Чтобы воспользоваться этой программой, укажите имя исходного и целевого
    файлов. Например, чтобы скопировать файл FIRST.DAT в файл SECOND.DAT,
    введите в командной строке следующее:
    CopyFile FIRST.DAT SECOND.DAT
    */
    

    class Program_19
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Применение : CopyFile Откуда Куда");
                return;
            }

            // Копировать файлы.
            try
            {
                File.Copy(args[0], args[1]);
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка копирования файла\n" + exc.Message);
            }

            Console.ReadKey();
        }
    }
}
