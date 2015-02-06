using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_3
{
    class Program_9
    {
        static void Main(string[] args)
        {
            decimal price;
            decimal discount;
            decimal discounted_price;
            // рассчитать цену со скидкой,
            price = 19.95m;
            discount = 0.15m; // норма скидки составляет 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Цена со скидкой: {0:С}", discounted_price);

            Console.ReadKey();
        }
    }
}
