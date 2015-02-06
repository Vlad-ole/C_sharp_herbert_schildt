using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{

    /* Уведомления о событиях получают отдельные объекты, когда метод экземпляра
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
        int id;
        public X(int x) { id = x; }
        
        // Этот метод экземпляра предназначен в качестве обработчика событий.
        public void Xhandler()
        {
            Console.WriteLine("Событие получено объектом " + id);
        }
    }

    class Program_14
    {


        static void Main(string[] args)
        {

            MyEvent evt = new MyEvent();
            X o1 = new X(1);
            X o2 = new X(2);
            X o3 = new X(3);
            evt.SomeEvent += o1.Xhandler;
            evt.SomeEvent += o2.Xhandler;
            evt.SomeEvent += o3.Xhandler;

            // Запустить событие.
            evt.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
