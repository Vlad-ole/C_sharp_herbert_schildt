using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_14
{
    // Ввод с консоли с помощью метода ReadLine().
    
    class Program_2
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите несколько символов.");
            
            str = Console.ReadLine();
            Console.WriteLine("Вы ввели: " + str);

            Console.ReadKey();
        }
    }
}
