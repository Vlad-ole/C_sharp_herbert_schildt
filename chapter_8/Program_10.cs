using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{

    // Поменять местами две ссылки.


    class RefSwap
    {
        int a, b;
        public RefSwap(int i, int j)
        {
            a = i;
            b = j;
        }
        
        public void Show()
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
        
        // Этот метод изменяет свои аргументы.
        public void Swap(ref RefSwap ob1,  ref RefSwap ob2)
        {
            RefSwap t;
            t = ob1;
            ob1 = ob2;
            ob2 = t;
        }
    }

    class Program_10
    {
        static void Main(string[] args)
        {
            RefSwap x = new RefSwap(1, 2);
            RefSwap у = new RefSwap(3, 4);
            Console.Write("x до вызова: ");
            x.Show();
            Console.Write("у до вызова: ");
            у.Show();
            Console.WriteLine();
            // Смена объектов, на которые ссылаются аргументы х и у.
            x.Swap(ref x, ref у);
            Console.Write("х после вызова: ");
            x.Show();
            Console.Write("у после вызова: ");
            у.Show();

            Console.ReadKey();
        }
    }
}
