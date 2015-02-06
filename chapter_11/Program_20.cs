﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_11
{

    // Продемонстрировать применение метода ToString()

    class MyClass
    {
        static int count = 0;
        int id;

        public MyClass()
        {
            id = count;
            count++;
        }

        public override string ToString()
        {
            return "Объект #" + id + " типа MyClass";
        }
    }

    class Program_20
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass();
            MyClass ob2 = new MyClass();
            MyClass ob3 = new MyClass();
            Console.WriteLine(ob1);
            Console.WriteLine(ob2);
            Console.WriteLine(ob3);


            Console.ReadKey();
        }
    }
}
