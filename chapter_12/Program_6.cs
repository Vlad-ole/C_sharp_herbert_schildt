using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12
{
    // Пример наследования интерфейсов.

    public interface IA
    {
        void Meth1();
        void Meth2();
    }
    
    // В базовый интерфейс включены методы Meth1() и Meth2().
    // а в производный интерфейс добавлен еще один метод — Meth3().
    
    public interface IB : IA
    {
        void Meth3();
    }
    
    // В этом классе должны быть реализованы все методы интерфейсов IA и IB.
    class MyClass : IB
    {
        public void Meth1()
        {
            Console.WriteLine("Реализовать метод Meth1().");
        }
        
        public void Meth2()
        {
            Console.WriteLine("Реализовать метод Meth2().");
        }
        
        public void Meth3()
        {
            Console.WriteLine("Реализовать метод Meth3().");
        }
    }



    class Program_6
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.Meth1();
            ob.Meth2();
            ob.Meth3();

            Console.ReadKey();

        }
    }
}
