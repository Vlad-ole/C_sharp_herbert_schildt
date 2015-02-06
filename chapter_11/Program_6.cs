using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Добавить дополнительные конструкторы в класс TwoDShape.

    class TwoDShape
    {
        double pri_width;
        double pri_height;
        
        // Конструктор, вызываемый по умолчанию.
        public TwoDShape()
        {
            Width = Height = 0.0;
        }
        
        // Конструктор класса TwoDShape.
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        
        // Сконструировать объект равной ширины и высоты.
        public TwoDShape(double x)
        {
            Width = Height = x;
        }
        
        // Свойства ширины и высоты объекта.
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }
        
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }
        
        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " +
            Width + " и " + Height);
        }
    }

    // Класс для треугольников, производный от класса TwoDShape.
    class Triangle : TwoDShape
    {
        string Style;
        
        /* Конструктор, используемый по умолчанию.
        Автоматически вызывает конструктор, доступный по
        умолчанию в классе TwoDShape. */
        public Triangle()
        {
            Style = "null";
        }
        
        // Конструктор, принимающий три аргумента.
        public Triangle(string s, double w, double h): base(w, h)
        {
            Style = s;
        }
        
        // Сконструировать равнобедренный треугольник.
        public Triangle(double x): base(x)
        {
            Style = "равнобедренный";
        }
        
        // Возвратить площадь треугольника.
        public double Area()
        {
            return Width * Height / 2;
        }
       
        // Показать тип треугольника.
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }

    class Program_6
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
            Triangle t3 = new Triangle(4.0);
            
            t1 = t2;
            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            
            t1.ShowDim();
            Console.WriteLine("Площадь равна " + t1.Area());
            Console.WriteLine();

            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            
            Console.WriteLine("Площадь равна " + t2.Area());
            Console.WriteLine();
            
            Console.WriteLine("Сведения об объекте t3: ");
            t3.ShowStyle();
            t3.ShowDim();
            
            Console.WriteLine("Площадь равна " + t3.Area());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
