using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_7
{
    class Program_12
    {
    

        static void Main(string[] args)
        {
            // Поменять местами содержимое элементов массива.

            int i, j;
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];
            
            for (i = 0; i < nums1.Length; i++) nums1[i] = i;
            
            Console.Write("Исходное содержимое массива: ");           
            for (i = 0; i < nums2.Length; i++)
                Console.Write(nums1[i] + " ");
            Console.WriteLine();
            
            // Скопировать элементы массива nums1 в массив nums2 в обратном порядке.
            if (nums2.Length >= nums1.Length) // проверить, достаточно ли 
                // длины массива nums2
                for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
                    nums2[j] = nums1[i];
           
            Console.Write("Содержимое массива в обратном порядке: ");
            for (i = 0; i < nums2.Length; i++)
                Console.Write(nums2[i] + " ");
            Console.WriteLine();



            Console.ReadKey();

        }
    }
}
