﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{
    /* Копировать файл.
Чтобы воспользоваться этой программой, укажите имена исходного и выходного
файлов. Например, для копирования файла FIRST.DAT в файл SECOND.DAT
введите в командной строке следующее:
CopyFile FIRST.DAT SECOND.DAT
*/

    class Program_9
    {
        static void Main(string[] args)
        {
            int i;
            FileStream fin = null;
            FileStream fout = null;
            if (args.Length != 2)
            {
                Console.WriteLine("Применение: CopyFile Откуда Куда");
                return;
            }


            try
            {
                // Открыть файлы.
                fin = new FileStream(args[0], FileMode.Open);
                fout = new FileStream(args[1], FileMode.Create);
                
                // Скопировать файл.
                do
                {
                    i = fin.ReadByte();
                    if (i != -1) fout.WriteByte((byte)i);
                } while (i != -1);
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }

            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }


            Console.ReadKey();
        }
    }
}
