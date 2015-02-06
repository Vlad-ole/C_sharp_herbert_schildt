using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{
    // Простая сервисная программа ввода с диска и вывода на экран,
    // демонстрирующая применение класса StreamReader.

    class Program_12
    {
        static void Main(string[] args)
        {

            FileStream fin;
            string s;

            try
            {
                fin = new FileStream("test.txt", FileMode.Open);
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }

            StreamReader fstr_in = new StreamReader(fin);
            
            try
            {
                while ((s = fstr_in.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }

            finally
            {
                fstr_in.Close();
            }

            Console.ReadKey();
        }
    }
}
