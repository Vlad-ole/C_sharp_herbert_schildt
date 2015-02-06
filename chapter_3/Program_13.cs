using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_13
    {
        static void Main(string[] args)
        {
            // Эти переменные типизированы неявно. Они отнесены
            // к типу double, поскольку инициализирующие их
            // выражения сами относятся к типу double.
            var s1 = 4.0;
            var s2 = 5.0;
            // Итак, переменная hypot типизирована неявно и
            // относится к типу double, поскольку результат,
            // возвращаемый методом Sqrt(), имеет тип double.
            var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Гипотенуза треугольника со сторонами " +
            s1 + " by " + s2 + " равна ");
            Console.WriteLine("{0:#.###}.", hypot);
            // Следующий оператор не может быть скомпилирован,

            // поскольку переменная s1 имеет тип double и
            // ей нельзя присвоить десятичное значение.
            // s1 = 12.2М; // Ошибка!

            Console.ReadKey();
        }
    }
}
