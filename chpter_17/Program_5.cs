﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace chpter_17
{
    // Анализ методов с помощью рефлексии.

    class MyClass
    {
        int x;
        int y;

        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if (x < i && i < y) return true;
            else return false;

        }

        public void Set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void Show()
        {
            Console.WriteLine(" x: {0}, у: {1}", x, y);
        }

    }




    class Program_5
    {


        static void Main(string[] args)
        {
            Type t = typeof(MyClass); // получить объект класса Type,
            // представляющий класс MyClass

            Console.WriteLine("Анализ методов, определенных " + "в классе " + t.Name);
            Console.WriteLine();
            Console.WriteLine("Поддерживаемые методы: ");
            MethodInfo[] mi = t.GetMethods();
            
            // Вывести методы, поддерживаемые в классе MyClass.
            foreach (MethodInfo m in mi)
            {
                // Вывести возвращаемый тип и имя каждого метода.
                Console.Write(" " + m.ReturnType.Name + " " + m.Name + "(");
                // Вывести параметры.
                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }

                Console.WriteLine(")");
                Console.WriteLine();


            }
            Console.ReadKey();

        }
    }
}
