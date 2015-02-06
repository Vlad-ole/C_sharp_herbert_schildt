using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_16
{
    using Counter;
    using AnotherCounter;

    // Продемонстрировать применение описателя ::.

    // Присвоить классу Counter псевдоним Ctr.
    using Ctr = Counter;
    // Объявить пространство имен для счетчиков.
    namespace Counter
    {
        // Простой вычитающий счетчик.
        class CountDown
        {
            int val;
            public CountDown(int n)
            {
                val = n;
            }
            // ...
        }
    }

    // Объявить еще одно пространство имен для счетчиков.
    namespace AnotherCounter
    {
        // Объявить еще один класс CountDown, принадлежащий
        // пространству имен AnotherCounter.
        class CountDown
        {
            int val;
            public CountDown(int n)
            {
                val = n;
            }
            // ...
        }
    }

    class Program_7
    {
        static void Main()
        {

            // Здесь оператор :: разрешает конфликт, предписывая компилятору
            // использовать класс CountDown из пространства имен Counter.
            Ctr::CountDown cd1 = new Ctr::CountDown(10);
            // ...

            Console.ReadKey();
        }
    }
}
