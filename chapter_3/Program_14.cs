using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_14
    {
        static void Main(string[] args)
        {
            int x; // Эта переменная доступна для всего кода внутри метода Main().
            x = 10;
            if (x == 10)
            { // начать новую область действия
                int у = 20; // Эта переменная доступна только в данном кодовом блоке.
                // Здесь доступны обе переменные, х и у.
                Console.WriteLine("х и у: " + x + " " + у);
                x = у * 2;
            }
            // у = 100; // Ошибка! Переменна у здесь недоступна.
            // А переменная х здесь по-прежнему доступна.
            Console.WriteLine("х равно " + x);

            Console.ReadKey();
        }
    }
}
