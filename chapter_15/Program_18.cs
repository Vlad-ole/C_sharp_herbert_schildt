using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    // Пример формирования .NET-совместимого события.

    // Объявить класс, производный от класса EventArgs.
    class MyEventArgs : EventArgs
    {
        public int EventNum;
    }

    // Объявить тип делегата для события.
    delegate void MyEventHandler(object source, MyEventArgs arg);

    // Объявить класс, содержащий событие.
    class MyEvent
    {
        static int count = 0;
        public event MyEventHandler SomeEvent;

        // Этот метод запускает событие SomeEvent.
        public void OnSomeEvent()
        {
            MyEventArgs arg = new MyEventArgs();
            if (SomeEvent != null)
            {
                arg.EventNum = count++;
                SomeEvent(this, arg);
            }
        }
    }

    class X
    {
        public void Handler(object source, MyEventArgs arg)
        {
            Console.WriteLine("Событие " + arg.EventNum + " получено объектом класса X.");
            Console.WriteLine("Источник: " + source);
            Console.WriteLine();
        }
    }

    class Y
    {
        public void Handler(object source, MyEventArgs arg)
        {
            Console.WriteLine("Событие " + arg.EventNum + " получено объектом класса Y.");
            Console.WriteLine("Источник: " + source);
            Console.WriteLine();
        }
    }


    class Program_18
    {


        static void Main(string[] args)
        {
            X ob1 = new X();
            Y ob2 = new Y();
            MyEvent evt = new MyEvent();
            
            // Добавить обработчик Handler() в цепочку событий.
            evt.SomeEvent += ob1.Handler;
            evt.SomeEvent += ob2.Handler;
            
            // Запустить событие.
            evt.OnSomeEvent();
            evt.OnSomeEvent();


            Console.ReadKey();
        }
    }
}
