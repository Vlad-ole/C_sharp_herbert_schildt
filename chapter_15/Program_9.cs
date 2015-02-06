using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Применить два одиночных лямбда-выражения.

    // Объявить делегат, принимающий аргумент типа int и
    // возвращающий результат типа int.
    delegate int Incr(int v);

    // Объявить делегат, принимающий аргумент типа int и
    // возвращающий результат типа bool.
    delegate bool IsEven(int v);

    class Program_9
    {


        static void Main(string[] args)
        {
            // Создать делегат Incr, ссылающийся на лямбда-выражение.
            // увеличивающее свой параметр на 2.
            Incr incr = count => count + 2;
            
            // А теперь использовать лямбда-выражение incr.
            Console.WriteLine("Использование лямбда-выражения incr: ");
            int x = -10;
            while (x <= 0)
            {
                Console.Write(x + " ");
                x = incr(x); // увеличить значение x на 2
            }
            Console.WriteLine("\n");

            // Создать экземпляр делегата IsEven, ссылающийся на лямбда-выражение,
            // возвращающее логическое значение true, если его параметр имеет четное
            // значение, а иначе — логическое значение false.
            IsEven isEven = n => n % 2 == 0;

            // А теперь использовать лямбда-выражение isEven.
            Console.WriteLine("Использование лямбда-выражения isEven: ");
            for (int i = 1; i <= 10; i++)
                if (isEven(i)) Console.WriteLine(i + " четное.");

            Console.ReadKey();
        }
    }
}
