using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_4
{
    class Program_6
    {
        static void Main(string[] args)
        {
            // Продемонстрировать значение побочных эффектов.

            int i;
            bool someCondition = false;
            i = 0;

            // Значение переменной i инкрементируется,
            // несмотря на то, что оператор if не выполняется.
            if (someCondition & (++i < 100))
                Console.WriteLine("He выводится");
            Console.WriteLine("Оператор if выполняется: " + i); // выводится 1
            // В данном случае значение переменной i не инкрементируется,
            // поскольку инкремент в укороченном логическом операторе опускается.
            if (someCondition && (++i < 100))
                Console.WriteLine("He выводится");
            Console.WriteLine("Оператор if выполняется: " + i); // по-прежнему 1 !!

            Console.ReadKey();
        }
    }
}
