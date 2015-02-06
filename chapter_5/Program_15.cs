using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_15
    {
        static void Main(string[] args)
        {

            // Объявить переменную управления циклом в самом цикле for.

            int sum = 0;
            int fact = 1;
            // вычислить факториал чисел от 1 до 5
            for (int i = 1; i <= 5; i++)
            {
                sum += i; // Переменная i действует в цикле.
                fact *= i;
            }
            // А здесь переменная i недоступна.
            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Факториал равен " + fact);

            Console.ReadKey();
        }
    }

}
