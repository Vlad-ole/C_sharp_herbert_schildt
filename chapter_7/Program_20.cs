using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_20
    {
        // Создать и вывести символьную строку.

        static void Main(string[] args)
        {

            char[] charray = { 'Э', 'т', 'o', ' ', 'с', 't', 'p', 'o', 'к', 'a' };
            string strl = new string(charray);
            string str2 = "Еще одна строка.";
            Console.WriteLine(strl);
            Console.WriteLine(str2);


            Console.ReadKey();

        }
    }
}
