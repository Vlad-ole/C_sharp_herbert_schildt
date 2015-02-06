using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{

    // Простая сервисная программа ввода с клавиатуры и вывода на диск,
    // демонстрирующая применение класса StreamWriter.

    class Program_10
    {
        static void Main(string[] args)
        {
            string str;
            FileStream fout;
            
            // Открыть сначала поток файлового ввода-вывода.
            try
            {
                fout = new FileStream("test.txt", FileMode.Create);
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }
            
            // Заключить поток файлового ввода-вывода в оболочку класса StreamWriter.
            StreamWriter fstr_out = new StreamWriter(fout);
            try
            {
                Console.WriteLine("Введите текст, а по окончании — 'стоп'.");
                
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();
                    if (str != "стоп")
                    {
                        str = str + "\r\n"; // добавить новую строку
                        fstr_out.Write(str);
                    }
                } while (str != "стоп");
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }

            finally
            {
                fstr_out.Close();
            }

            Console.ReadKey();
        }
    }
}
