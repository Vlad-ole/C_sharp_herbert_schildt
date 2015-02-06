using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapter_14
{
    // Переадресовать поток Console.Out.

    class Program_13
    {
        static void Main(string[] args)
        {
            StreamWriter log_out = null;

            try
            {
                log_out = new StreamWriter("logfile.txt");
                
                // Переадресовать стандартный вывод в файл logfile.txt.
                Console.SetOut(log_out);
                Console.WriteLine("Это начало файла журнала регистрации.");
                
                for (int i = 0; i < 10; i++) 
                    Console.WriteLine(i);
                    
                Console.WriteLine("Это конец файла журнала регистрации.");
            }
            
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода\n" + exc.Message);
            }
            
            finally
            {
                if (log_out != null) log_out.Close();
            }



            //Console.ReadKey();
        }
    }
}
