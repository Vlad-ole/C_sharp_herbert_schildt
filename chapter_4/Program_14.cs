using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_14
    {
        static void Main(string[] args)
        {
            // Применить операторы сдвига для умножения и деления на 2.

            int n;
            n = 10;
            Console.WriteLine("Значение переменной n: " + n);
            // Умножить на 2.
            n = n << 1;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n * 2: " + n);
            // Умножить на 4.
            n = n << 2;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n * 4: " + n);
            // Разделить на 2.
            n = n >> 1;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n / 2: " + n);
            // Разделить на 4.
            n = n >> 2;
            Console.WriteLine("Значение переменной n после " +
            "операции n = n / 4: " + n);
            Console.WriteLine();

            // Установить переменную n в исходное состояние.
            n = 10;
            Console.WriteLine("Значение переменной n: " + n);

            // Умножить на 2 тридцать раз.
            n = n << 30; // данные теряются
            Console.WriteLine("Значение переменной п после " +
            "сдвига на 30 позиций влево: " + n);

            Console.ReadKey();
        }
    }
}
