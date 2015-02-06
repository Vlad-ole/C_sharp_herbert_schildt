using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_14
{
    // Считать символы, введенные с консоли, используя метод ReadKey().

    class Program_4
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keypress;
            Console.WriteLine("Введите несколько символов, " + "а по окончании - <Q>.");
            do
            {
                keypress = Console.ReadKey(); // считать данные о нажатых клавишах
                Console.WriteLine(" Вы нажали клавишу: " + keypress.KeyChar);
               
                // Проверить нажатие модифицирующих клавиш.
                if ((ConsoleModifiers.Alt & keypress.Modifiers) != 0)
                    Console.WriteLine("Нажата клавиша <Alt>.");
               
                if ((ConsoleModifiers.Control & keypress.Modifiers) != 0)
                    Console.WriteLine("Нажата клавиша <Control>.");
                
                if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0)
                    Console.WriteLine("Нажата клавиша <Shift>.");
            } while (keypress.KeyChar != 'Q');

            Console.ReadKey();
        }
    }
}
