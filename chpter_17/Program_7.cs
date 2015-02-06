﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace chpter_17
{
    // Создать объект с помощью рефлексии.

    class MyClass
    {
        int x;
        int y;

        public MyClass(int i)
        {
            Console.WriteLine("Конструирование класса MyClass(int, int). ");
            x = y = i;
        }

        public MyClass(int i, int j)
        {
            Console.WriteLine("Конструирование класса MyClass(int, int). ");
            x = i;
            y = j;
            Show();
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if ((x < i) && (i < y)) return true;
            else return false;
        }

        public void Set(int a, int b)
        {
            Console.Write("В методе Set(int, int). ");
            x = a;
            y = b;
            Show();
        }

        // Перегрузить метод Set.
        public void Set(double a, double b)
        {
            Console.Write("В методе(double, double). ");
            x = (int)a;
            y = (int)b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("Значение x: {0}, значение у: {1}", x, y);
        }
    }


    class Program_7
    {


        static void Main()
        {
            Type t = typeof(MyClass);
            int val;

            // Получить сведения о конструкторе.
            ConstructorInfo[] ci = t.GetConstructors();
            
            Console.WriteLine("Доступные конструкторы: ");
            foreach (ConstructorInfo с in ci)
            {
                // Вывести возвращаемый тип и имя.
                Console.Write(" " + t.Name + "(");

                // Вывести параметры.
                ParameterInfo[] pi = с.GetParameters();

                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(")");

            }

            Console.WriteLine();

            // Найти подходящий конструктор.
            int x;
            for (x = 0; x < ci.Length; x++)
            {
                ParameterInfo[] pi = ci[x].GetParameters();
                if (pi.Length == 2) break;
            }

            if (x == ci.Length)
            {
                Console.WriteLine("Подходящий конструктор не найден.");
                return;
            }
            else
                Console.WriteLine("Найден конструктор с двумя параметрами.\n");
            
            // Сконструировать объект.
            object[] consargs = new object[2];
            consargs[0] = 10;
            consargs[1] = 20;
            object reflectOb = ci[x].Invoke(consargs);
            Console.WriteLine("\nВызов методов для объекта reflectOb.");
            Console.WriteLine();
            MethodInfo[] mi = t.GetMethods();

            // Вызвать каждый метод.
            foreach (MethodInfo m in mi)
            {
                // Получить параметры.
                ParameterInfo[] pi = m.GetParameters();
                if (m.Name.CompareTo("Set") == 0 &&
                pi[0].ParameterType == typeof(int))
                {
                    // Это метод Set(int, int).
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflectOb, args);
                }

                else if (m.Name.CompareTo("Set") == 0 &&
                pi[0].ParameterType == typeof(double))
                {
                    // Это метод Set(double, double).
                    object[] args = new object[2];
                    args[0] = 1.12;
                    args[1] = 23.4;
                    m.Invoke(reflectOb, args);
                }

                else if (m.Name.CompareTo("Sum") == 0)
                {
                    val = (int)m.Invoke(reflectOb, null);
                    Console.WriteLine("Сумма равна " + val);
                }

                else if (m.Name.CompareTo("IsBetween") == 0)
                {
                    object[] args = new object[1];
                    args[0] = 14;
                    if ((bool)m.Invoke(reflectOb, args))
                        Console.WriteLine("Значение 14 находится между x и у");
                }

                else if (m.Name.CompareTo("Show") == 0)
                {
                    m.Invoke(reflectOb, null);
                }
            }

            Console.ReadKey();

        }



    }
}
