﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Добавить метод MyMeth(byte).

    class Overload2
    {
        public void MyMeth(byte x)
        {
            Console.WriteLine("В методе MyMeth(byte): " + x);
        }
        
        public void MyMeth(int x)
        {
            Console.WriteLine("В методе MyMeth(int): " + x);
        }
        
        public void MyMeth(double x)
        {

            Console.WriteLine("В методе MyMeth(double): " + x);
        }
    }


    class Program_18
    {
        static void Main(string[] args)
        {

            Overload2 ob = new Overload2();
            int i = 10;
            double d = 10.1;
            byte b = 99;
            short s = 10;
            float f = 11.5F;
            ob.MyMeth(i); // вызвать метод ob.MyMeth(int)
            ob.MyMeth(d); // вызвать метод ob.MyMeth(double)
            ob.MyMeth(b); // вызвать метод ob.MyMeth(byte) --
            // на этот раз без преобразования типа
            ob.MyMeth(s); // вызвать метод ob.MyMeth(int) -- с преобразованием типа
            ob.MyMeth(f); // вызвать метод ob.MyMeth(double) -- с преобразованием типа

            Console.ReadKey();
        }
    }
}
