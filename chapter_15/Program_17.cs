using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    // Использовать лямбда-выражение в качестве обработчика событий.

    // Объявить тип делегата для события.
    delegate void MyEventHandler(int n);

    // Объявить класс, содержащий событие.
    class MyEvent
    {
        public event MyEventHandler SomeEvent;
        
        // Этот метод вызывается для запуска события.
        public void OnSomeEvent(int n)
        {
            if (SomeEvent != null)
                SomeEvent(n);
        }
    }

    class Program_17
    {


        static void Main(string[] args)
        {

            MyEvent evt = new MyEvent();
            
            // Использовать лямбда-выражение в качестве обработчика событий.
            evt.SomeEvent += (n) => Console.WriteLine("Событие получено (лямбда-выражение). Значение равно " + n);

            // Использовать анонимный метод в качестве обработчика событий.
            evt.SomeEvent += delegate(int n)
            {
                Console.WriteLine("Событие получено (анонимная функция). Значение равно " + n);
            };
            
            // Запустить событие.
            evt.OnSomeEvent(1);
            evt.OnSomeEvent(2);

            Console.ReadKey();
        }
    }
}
