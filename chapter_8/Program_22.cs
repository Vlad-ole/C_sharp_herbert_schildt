using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Простой пример, демонстрирующий применение инициализаторов объектов.

    class MyClass
    {
        public int Count;
        public string Str;
    }
    
    class Program_22
    {
        static void Main(string[] args)
        {
            // Сконструировать объект типа MyClass, используя инициализаторы объектов.
            MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };
            Console.WriteLine(obj.Count + " " + obj.Str);

            Console.ReadKey();
        }
    }
}
