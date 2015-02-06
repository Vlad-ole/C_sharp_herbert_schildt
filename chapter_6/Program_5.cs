using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_6
{
    // Простой пример применения параметра.

    class ChkNum
    {
        // Возвратить значение true, если значение
        // параметра х окажется простым числом.
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0) return false;
            return true;
        }
    }

    class Program_5
    {
        static void Main(string[] args)
        {
            ChkNum ob = new ChkNum();
            for (int i = 2; i < 10; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i + " простое число.");
                else Console.WriteLine(i + " непростое число.");

            Console.ReadKey();
        }
    }
}
