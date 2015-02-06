using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_14
{
    // Прочитать введенную с клавиатуры строку
    // непосредственно из потока Console.In.
    
    class Program_3
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите несколько символов.");
            
            str = Console.In.ReadLine(); // вызвать метод ReadLine() класса TextReader
            Console.WriteLine("Вы ввели: " + str);

            Console.ReadKey();
        }
    }
}
