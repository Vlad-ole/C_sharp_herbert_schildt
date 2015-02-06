using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{
    // Открыть файл средствами класса StreamWriter.

    class Program_11
    {
        static void Main(string[] args)
        {
            string str;
            StreamWriter fstr_out = null;
            
            try
            {
                // Открыть файл, заключенный в оболочку класса StreamWriter.

                fstr_out = new StreamWriter("test.txt");
                Console.WriteLine("Введите текст, а по окончании — 'стоп'.");
                do
                {
                    Console.Write(" : ");
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
                if (fstr_out != null) fstr_out.Close();
            }

            Console.ReadKey();
        }
    }
}
