using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_10
{
    // Применить инициализаторы объектов в свойствах.

    class MyClass
    {
        // Теперь это свойства.
        public int Count { get; set; }
        public string Str { get; set; }
    }

    class Program_8
    {
        static void Main(string[] args)
        {

            // Сконструировать объект типа MyClass с помощью инициализаторов объектов.
            MyClass obj = new MyClass { Count = 100, Str = "Тестирование" };
            Console.WriteLine(obj.Count + " " + obj.Str);


            Console.ReadKey();
        }
    }
}
