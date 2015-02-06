using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_3
    {
        // Вычислить среднее арифметическое ряда значений.

        static void Main(string[] args)
        {

            int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };
            int avg = 0;
            for (int i = 0; i < 10; i++)
                avg = avg + nums[i];
            
            avg = avg / 10;
            Console.WriteLine("Среднее: " + avg);


            int[] nums2 = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

            int[] nums3;
            nums3 = new int[] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

            int[] nums4 = new int[10] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };


            Console.ReadKey();

        }
    }
}
