using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_5
    {
        static void Main(string[] args)
        {

            // Использовать элементы типа char для управления оператором switch.

            char ch;
            for (ch = 'A'; ch <= 'E'; ch++)
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("ch содержит A");
                        break;
                    case 'B':
                        Console.WriteLine("ch содержит В");
                        break;
                    case 'C':
                        Console.WriteLine("ch содержит С");
                        break;
                    case 'D':
                        Console.WriteLine("ch содержит D");
                        break;
                    case 'E':
                        Console.WriteLine("ch содержит E");
                        break;
                }

            Console.ReadKey();
        }
    }
}
