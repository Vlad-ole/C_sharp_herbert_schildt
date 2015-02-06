using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{
    // Вызвать скрытый метод.

    class А
    {
        public int i = 0;
        
        // Метод Show() в классе A
        public void Show()
        {
            Console.WriteLine("Член i в базовом классе: " + i);
        }
    }
    
    // Создать производный класс.
    class В : А
    {
        new int i; // этот член скрывает член i из класса А
        public В(int a, int b)
        {
            base.i = a; // здесь обнаруживается скрытый член из класса А
            i = b; // член i из класса В
        }
        
        // Здесь скрывается метод Show() из класса А. Обратите
        // внимание на применение ключевого слова new.
        new public void Show()
        {
            base.Show(); // здесь вызывается метод Show() из класса А
            // далее выводится член i из класса В
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }

    class Program_9
    {
        static void Main(string[] args)
        {
            В ob = new В(1, 2);
            ob.Show();

            Console.ReadKey();
        }
    }
}
