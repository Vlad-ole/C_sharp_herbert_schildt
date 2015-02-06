using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_6
{
   //Ключевое слово this
    class Rect
    {
        public int Width;
        public int Height;
        public Rect(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }
        public int Area()
        {
            return this.Width * this.Height;
        }
    }
  

    class Program_14
    {
        static void Main()
        {

            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);
            Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
            Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());
                       

            Console.ReadKey();
        }
    }

}
