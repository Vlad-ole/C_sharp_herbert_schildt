using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Продемонстрировать групповую адресацию события.

    // Объявить тип делегата для события.
    delegate void MyEventHandler();

    // Объявить делегат, содержащий событие.
    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        // Этот метод вызывается для запуска события.
        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }

    class X
    {
        public void Xhandler()
        {
            Console.WriteLine("Событие получено объектом класса X");
        }

    }


    class Y
    {
        public void Yhandler()
        {
            Console.WriteLine("Событие получено объектом класса Y");
        }
    }


    class Program_13
    {

        static void Handler()
        {
            Console.WriteLine("Событие получено объектом класса EventDemo");
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            X xOb = new X();
            Y yOb = new Y();
            
            // Добавить обработчики в список событий.
            evt.SomeEvent += Handler;
            evt.SomeEvent += xOb.Xhandler;
            evt.SomeEvent += yOb.Yhandler;
            
            // Запустить событие.
            evt.OnSomeEvent();
            Console.WriteLine();
            
            // Удалить обработчик.
            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
