using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_13
{

    // Исключения производных классов должны появляться до
    // исключений базового класса.

    // Создать класс исключения.
    class ExceptA : Exception
    {
        public ExceptA(string str) : base(str) { }

        public override string ToString()
        {
            return Message;
        }
    }

    // Создать класс исключения, производный от класса ExceptA.
    class ExceptB : ExceptA
    {
        public ExceptB(string str) : base(str) { }
        
        public override string ToString()
        {
            return Message;
        }
    }



    class Program_15
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 3; x++)
            {
                try
                {
                    if (x == 0) throw new ExceptA("Перехват исключения типа ExceptA");
                    else if (x == 1) throw new ExceptB("Перехват исключения типа ExceptB");
                    else throw new Exception();
                }

                catch (ExceptB exc)
                {
                    Console.WriteLine(exc);
                }

                catch (ExceptA exc)
                {
                    Console.WriteLine(exc);
                }

                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }


            Console.ReadKey();
        }
    }
}
