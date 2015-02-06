using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    /* Уведомления о событии получает класс, когда статический метод
используется в качестве обработчика событий. */

    // Объявить тип делегата для события.
    delegate void MyEventHandler();

    // Объявить класс, содержащий событие.
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
        /* Этот статический метод предназначен в качестве
        обработчика событий. */
        public static void Xhandler()
        {
            Console.WriteLine("Событие получено классом.");
        }
    }

    class Program_15
    {


        static void Main(string[] args)
        {

            MyEvent evt = new MyEvent();
            evt.SomeEvent += X.Xhandler;
            
            // Запустить событие.
            evt.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
