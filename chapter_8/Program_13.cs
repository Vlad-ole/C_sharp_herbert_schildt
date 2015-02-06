using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Возвратить объект из метода.

    class Rect
    {
        int width;
        int height;

        public Rect(int w, int h)
        {
            width = w;
            height = h;
        }

        public int Area()
        {
            return width * height;
        }

        public void Show()
        {
            Console.WriteLine(width + " " + height);
        }

        /* Метод возвращает прямоугольник со сторонами, пропорционально
        увеличенными на указанный коэффициент по сравнению с вызывающим
        объектом прямоугольника. */
        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, height * factor);
        }
    }

    class Program_13
    {
        static void Main(string[] args)
        {

            Rect r1 = new Rect(4, 5);
            Console.Write("Размеры прямоугольника r1: ");
            r1.Show();
            Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
            Console.WriteLine();

            // Создать прямоугольник в два раза больший прямоугольника rl.
            Rect r2 = r1.Enlarge(2);
            Console.Write("Размеры прямоугольника r2: ");
            r2.Show();
            Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());

            Console.ReadKey();
        }
    }
}
