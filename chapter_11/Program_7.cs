using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{
    // Пример сокрытия имени с наследственной связью.   

    class А
    {
        public int i = 0;
    }
    
    // Создать производный класс.
    class В : А
    {
        new int i; // этот член скрывает член i из класса А

        public В(int b)
        {
            i = b; // член i в классе В
        }

        public void Show()
        {
            Console.WriteLine("Член i в производном классе: " + i);
        }
    }

    class Program_7
    {
        static void Main(string[] args)
        {
            В ob = new В(2);
            ob.Show();

            Console.ReadKey();
        }
    }
}
