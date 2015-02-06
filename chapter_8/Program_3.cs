﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_8
{
    // Пример передачи объектов методам по ссылке.

    class MyClass
    {
        int alpha, beta;
        public MyClass(int i, int j)
        {
            alpha = i;
            beta = j;
        }
        // Возвратить значение true, если параметр ob
        // имеет те же значения, что и вызывающий объект.
        public bool SameAs(MyClass ob)
        {
            if ((ob.alpha == alpha) & (ob.beta == beta))
                return true;
            else return false;
        }

        // Сделать копию объекта ob.
        public void Copy(MyClass ob)
        {
            alpha = ob.alpha;
            beta = ob.beta;
        }
        public void Show()
        {
            Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
        }
    }




    class Program_3
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(4, 5);
            MyClass ob2 = new MyClass(6, 7);
            Console.Write("ob1: ");
            ob1.Show();
            Console.Write("ob2: ");
            ob2.Show();
            if (ob1.SameAs(ob2))
                Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
            else
                Console.WriteLine("ob1 и ob2 имеют разные значения.");
            Console.WriteLine();
            // А теперь сделать объект ob1 копией объекта ob2.
            ob1.Copy(ob2);
            Console.Write("оЫ после копирования: ");
            ob1.Show();
            if (ob1.SameAs(ob2))
                Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
            else
                Console.WriteLine("ob1 и ob2 имеют разные значения.");


            Console.ReadKey();
        }
    }
}
