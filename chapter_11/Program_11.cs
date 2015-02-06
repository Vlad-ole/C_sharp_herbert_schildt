using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Продемонстрировать порядок вызова конструкторов.

    // Создать базовый класс.
    class А
    {
        public А()
        {
            Console.WriteLine("Конструирование класса А.");
        }
    }

    // Создать класс, производный от класса А.
    class В : А
    {
        public В()
        {
            Console.WriteLine("Конструирование класса В.");
        }
    }

    // Создать класс, производный от класса В.
    class С : В
    {
        public С()
        {
            Console.WriteLine("Конструирование класса С.");
        }
    }
    
    class Program_11
    {
        static void Main(string[] args)
        {
            С с = new С();           

            Console.ReadKey();
        }
    }
}
