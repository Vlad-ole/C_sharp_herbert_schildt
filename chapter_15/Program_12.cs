using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Очень простой пример, демонстрирующий событие.

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


    class Program_12
    {
        // Обработчик события.
        static void Handler()
        {
            Console.WriteLine("Произошло событие");
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            
            // Добавить метод Handler() в список событий.
            evt.SomeEvent += Handler;
            
            // Запустить событие.
            evt.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
