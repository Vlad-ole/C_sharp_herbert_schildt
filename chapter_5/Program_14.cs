using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_5
{
    class Program_14
    {
        static void Main(string[] args)
        {

            // Тело цикла может быть пустым.

            int i;
            int sum = 0;
            // получить сумму чисел от 1 до 5
            for (i = 1; i <= 5; sum += i++) ;
            Console.WriteLine("Сумма равна " + sum);

            Console.ReadKey();
        }
    }

}
