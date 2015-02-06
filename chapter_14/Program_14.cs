using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{

    // Записать двоичные данные, а затем считать их обратно.

    class Program_14
    {
        static void Main(string[] args)
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;
            
            int i = 10;
            double d = 1023.56;
            bool b = true;
            string str = "Это тест";
            
            // Открыть файл для вывода.
            try
            {
                dataOut = new
                BinaryWriter(new FileStream("testdata", FileMode.Create));
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }
            
            // Записать данные в файл.
            try
            {
                Console.WriteLine("Запись " + i);
                dataOut.Write(i);
                
                Console.WriteLine("Запись " + d);
                dataOut.Write(d);
                
                Console.WriteLine("Запись " + b);
                dataOut.Write(b);

                Console.WriteLine("Запись " + 12.2 * 7.4);
                dataOut.Write(12.2 * 7.4);

                Console.WriteLine("Запись " + str);
                dataOut.Write(str);
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            
            finally
            {
                dataOut.Close();
            }
            Console.WriteLine();
           
            // А теперь прочитать данные из файла.
            try
            {
                dataIn = new
                BinaryReader(new FileStream("testdata", FileMode.Open));
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }
            
            try
            {
                i = dataIn.ReadInt32();
                Console.WriteLine("Чтение " + i);
                
                d = dataIn.ReadDouble();
                Console.WriteLine("Чтение " + d);
                
                b = dataIn.ReadBoolean();
                Console.WriteLine("Чтение " + b);
                
                d = dataIn.ReadDouble();
                Console.WriteLine("Чтение " + d);
                
                str = dataIn.ReadString();
                Console.WriteLine("Чтение " + str);
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            
            finally
            {
                dataIn.Close();
            }

            Console.ReadKey();
        }
    }
}
