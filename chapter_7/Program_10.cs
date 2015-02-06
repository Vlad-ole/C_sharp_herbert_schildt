using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_10
    {
    

        static void Main(string[] args)
        {

            // Использовать свойство Length массива.

            int[] nums = new int[10];
            
            
            Console.WriteLine("Длина массива nums равна " + nums.Length);
            // Использовать свойство Length для инициализации массива nums.
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i * i;
            
            
            // А теперь воспользоваться свойством Length
            // для вывода содержимого массива nums.
            Console.Write("Содержимое массива nums: ");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
