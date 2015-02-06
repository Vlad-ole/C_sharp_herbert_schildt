using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12
{

    // Использовать свойство в интерфейсе.

    public interface ISeries
    {
        // Интерфейсное свойство.
        int Next
        {
            get; // возвратить следующее по порядку число
            set; // установить следующее число
        }
    }

    // Реализовать интерфейс ISeries.
    class ByTwos : ISeries
    {
        int val;

        public ByTwos()
        {
            val = 0;
        }

        // Получить или установить значение.
        public int Next
        {
            get
            {
                val += 2;
                return val;
            }

            set
            {
                val = value;
            }
        }
    }


    // Продемонстрировать применение интерфейсного свойства.
    class Program_4
    {
        static void Main(string[] args)
        {
            ByTwos ob = new ByTwos();
            
            // Получить доступ к последовательному ряду чисел с помощью свойства.
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.Next);
            
            Console.WriteLine("\nНачать с числа 21");
            
            ob.Next = 21;
            
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ob.Next);

            Console.ReadKey();

        }
    }
}
