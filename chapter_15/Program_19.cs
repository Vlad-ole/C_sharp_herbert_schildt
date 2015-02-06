using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_15
{
    // Использовать встроенный делегат EventHandler.

    // Объявить класс, содержащий событие,
    class MyEvent
    {
        public event EventHandler SomeEvent; // использовать делегат EventHandler
        
        // Этот метод вызывается для запуска события.
        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent(this, EventArgs.Empty);

        }
    }


    class Program_19
    {
        static void Handler(object source, EventArgs arg)
        {
            Console.WriteLine("Произошло событие");
            Console.WriteLine("Источник: " + source);
        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            
            // Добавить обработчик Handler() в цепочку событий.
            evt.SomeEvent += Handler;
            
            // Запустить событие.
            evt.OnSomeEvent();

            Console.ReadKey();
        }
    }
}
