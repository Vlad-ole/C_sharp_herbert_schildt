using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_14
{
    // Считать символ, введенный с клавиатуры.
    
    class Program_1
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Нажмите клавишу, а затем — <ENTER>: ");
            
            ch = (char)Console.Read(); // получить значение типа char
            Console.WriteLine("Вы нажали клавишу: " + ch);

            Console.ReadKey();
        }
    }
}
