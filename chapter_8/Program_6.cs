using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Использовать модификатор ref для передачи значения обычного типа по ссылке.

    class RefTest
    {
        // Этот метод изменяет свой аргумент. Обратите
        // внимание на применение модификатора ref.
        public void Sqr(ref int i)
        {
            i = i * i;
        }
    }

    class Program_6
    {
        static void Main(string[] args)
        {

            RefTest ob = new RefTest();
            int a = 10;
            Console.WriteLine("а до вызова: " + a);
            ob.Sqr(ref a); // обратите внимание на применение модификатора ref
            Console.WriteLine("а после вызова: " + a);


            Console.ReadKey();
        }
    }
}
