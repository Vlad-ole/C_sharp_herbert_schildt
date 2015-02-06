﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter_6
{

    // Добавить метод, принимающий два аргумента.   

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


        // Возвратить наименьший общий множитель.

        public int LeastComFactor(int a, int b)
        {
            int max;
            if (IsPrime(a) || IsPrime(b)) return 1;
            max = a < b ? a : b;
            for (int i = 2; i <= max / 2; i++)
                if (((a % i) == 0) && ((b % i) == 0)) return i;
            return 1;
        }
    }



    class Program_6
    {
        static void Main(string[] args)
        {

            ChkNum ob = new ChkNum();
            int a, b;
            for (int i = 2; i < 10; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i + " простое число.");
                else Console.WriteLine(i + " непростое число.");

            a = 7;
            b = 8;
            Console.WriteLine("Наименьший общий множитель чисел " +
            a + " и " + b + " равен " +
            ob.LeastComFactor(a, b));
            a = 100;
            b = 8;
            Console.WriteLine("Наименьший общий множитель чисел " +
            a + " и " + b + " равен " +
            ob.LeastComFactor(a, b));


            a = 100;
            b = 75;
            Console.WriteLine("Наименьший общий множитель чисел " +
            a + " и " + b + " равен " +
            ob.LeastComFactor(a, b));


            Console.ReadKey();
        }
    }
}
