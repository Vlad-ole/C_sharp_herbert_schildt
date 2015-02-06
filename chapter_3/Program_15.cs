using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_15
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 0; x < 3; x++)
            {
                int у = -1; // Переменная у инициализируется при каждом входе в блок.
                Console.WriteLine("у равно: " + у); // Здесь всегда выводится -1
                у = 100;
                Console.WriteLine("у теперь равно: " + у);
            }
            Console.ReadKey();
        }
    }
}
