﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{

    // Продемонстрировать произвольный доступ к файлу.

    class Program_16
    {
        static void Main(string[] args)
        {
            FileStream f = null;
            char ch;
            
            try
            {
                f = new FileStream("random.dat", FileMode.Create);
                
                // Записать английский алфавит в файл.
                for (int i = 0; i < 26; i++)
                    f.WriteByte((byte)('A' + i));
                
                // А теперь считать отдельные буквы английского алфавита.
                f.Seek(0, SeekOrigin.Begin); // найти первый байт
                ch = (char)f.ReadByte();
                Console.WriteLine("Первая буква: " + ch);
                
                f.Seek(1, SeekOrigin.Begin); // найти второй байт
                ch = (char)f.ReadByte();
                Console.WriteLine("Вторая буква: " + ch);
                
                f.Seek(4, SeekOrigin.Begin); // найти пятый байт
                ch = (char)f.ReadByte();
                Console.WriteLine("Пятая буква: " + ch);
                Console.WriteLine();

                // А теперь прочитать буквы английского алфавита через одну.
                Console.WriteLine("Буквы алфавита через одну: ");
                for (int i = 0; i < 26; i += 2)
                {
                    f.Seek(i, SeekOrigin.Begin); // найти i-й символ
                    ch = (char)f.ReadByte();
                    Console.Write(ch + " ");
                }
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc.Message);
            }
            
            finally
            {
                if (f != null) f.Close();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
