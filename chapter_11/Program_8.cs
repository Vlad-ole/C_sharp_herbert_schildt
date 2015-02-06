using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{
    class А
    {
        public int i = 0;
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

        public void Show()
        {
            // Здесь выводится член i из класса А.
            Console.WriteLine("Член i в базовом классе: " + base.i);
            
            // А здесь выводится член i из класса В.
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }

    class Program_8
    {
        static void Main(string[] args)
        {
            В ob = new В(1, 2);
            ob.Show();

            Console.ReadKey();
        }
    }
}
