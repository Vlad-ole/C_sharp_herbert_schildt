using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_9
{
    /* Более совершенный способ перегрузки логических
операторов !, | и & для объектов класса ThreeD.
В этом варианте укороченные логические операторы && и ||
становятся доступными для применения автоматически. */

   /* Для того чтобы применение укороченных логических операторов && и || стало
возможным, необходимо соблюсти следующие четыре правила. 
    * 
    * Во-первых, в классе должна быть произведена перегрузка логических операторов & и |.
    * 
    * Во-вторых, перегружаемые методы операторов & и | должны возвращать значение того же типа, что и у класса, для которого эти операторы перегружаются. 
    * 
    * В-третьих, каждый параметр должен содержать ссылку на объект того класса, для которого перегружается логический оператор. 
    * 
    * И в-четвертых, для класса должны быть перегружены операторы true и false. 
    * 
    * Если все эти условия выполняются, то укороченные логические операторы автоматически становятся пригодными для применения. */

    // Класс для хранения трехмерных координат.
    class ThreeD
    {
        int x, y, z; // трехмерные координаты
        public ThreeD() { x = y = z = 0; }
        public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

        // Перегрузить логический оператор | для укороченного вычисления.
        public static ThreeD operator |(ThreeD op1, ThreeD op2)
        {
            if (((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) |
            ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))
                return new ThreeD(1, 1, 1);
            else
                return new ThreeD(0, 0, 0);
        }

        // Перегрузить логический оператор & для укороченного вычисления.
        public static ThreeD operator &(ThreeD op1, ThreeD op2)
        {
            if (((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) &
            ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))
                return new ThreeD(1, 1, 1);
            else
                return new ThreeD(0, 0, 0);
        }

        // Перегрузить логический оператор !.
        public static bool operator !(ThreeD op)
        {
            if (op) return false;
            else return true;
        }

        // Перегрузить оператор true.
        public static bool operator true(ThreeD op)
        {
            if ((op.x != 0) || (op.y != 0) || (op.z != 0))
                return true; // хотя бы одна координата не равна нулю
            else
                return false;
        }

        // Перегрузить оператор false.
        public static bool operator false(ThreeD op)
        {
            if ((op.x == 0) && (op.y == 0) && (op.z == 0))
                return true; // все координаты равны нулю
            else

                return false;
        }

        // Ввести координаты X, Y, Z.
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }

    class Program_9
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(5, 6, 7);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD(0, 0, 0);
            Console.Write("Координаты точки a: ");
            a.Show();
            Console.Write("Координаты точки b: ");
            b.Show();
            Console.Write("Координаты точки с: ");
            c.Show();
            Console.WriteLine();
            if (a) Console.WriteLine("Точка а истинна.");
            if (b) Console.WriteLine("Точка b истинна.");
            if (c) Console.WriteLine("Точка с истинна.");
            if (!a) Console.WriteLine("Точка а ложна.");
            if (!b) Console.WriteLine("Точка b ложна.");
            if (!c) Console.WriteLine("Точка с ложна.");
            Console.WriteLine();
            Console.WriteLine("Применение логических операторов & и |");
            if (a & b) Console.WriteLine("а & b истинно.");
            else Console.WriteLine("а & b ложно.");

            if (a & c) Console.WriteLine("а & с истинно.");
            else Console.WriteLine("а & с ложно.");
            
            if (a | b) Console.WriteLine("a | b истинно.");
            else Console.WriteLine("а | b ложно.");
            
            if (a | c) Console.WriteLine("а | с истинно.");
            else Console.WriteLine("а | с ложно.");
            Console.WriteLine();
            
            // А теперь применить укороченные логические операторы.
            Console.WriteLine("Применение укороченных" +
            "логических операторов && и ||");
            if (a && b) Console.WriteLine("a && b истинно.");
            else Console.WriteLine("а && b ложно.");

            if (a && c) Console.WriteLine("а && с истинно.");
            else Console.WriteLine("a && с ложно.");
            
            if (a || b) Console.WriteLine("a || b истинно.");
            else Console.WriteLine("a || b ложно.");
            
            if (a || c) Console.WriteLine("a || с истинно.");
            else Console.WriteLine("a || с ложно.");

            Console.ReadKey();
        }
    }
}
