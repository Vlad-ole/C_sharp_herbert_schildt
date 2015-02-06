using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{
    // Записать данные в файл.

    class Program_8
    {
        static void Main(string[] args)
        {

            FileStream fout = null;
            
            try
            {
                // Открыть выходной файл.
                fout = new FileStream("test.txt", FileMode.CreateNew);
                // Записать весь английский алфавит в файл.
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    Console.WriteLine(i);
                    fout.WriteByte( (byte) i );
                }
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            
            finally
            {
                if (fout != null) fout.Close();
            }

            Console.ReadKey();
        }
    }
}
