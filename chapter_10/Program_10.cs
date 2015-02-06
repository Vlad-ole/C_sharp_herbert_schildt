using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_10
{

    // Применить автоматически реализуемые и доступные
    // только для чтения свойства Length и Error.

    class FailSoftArray
    {
        int[] a; // ссылка на базовый массив
        // Построить массив по заданному размеру.
        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }
        
        // Автоматически реализуемое и доступное только для чтения свойство Length.
        public int Length { get; private set; }
        
        // Автоматически реализуемое и доступное только для чтения свойство Error.
        public bool Error { get; private set; }
        
        // Это индексатор для массива FailSoftArray.
        public int this[int index]
        {
            // Это аксессор get.
            get
            {
                if (ok(index))
                {
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            // Это аксессор set.
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    Error = false;
                }
                else Error = true;
            }
        }
        // Возвратить логическое значение true, если
        // индекс находится в установленных границах.
        private bool ok(int index)
        {
            if (index >= 0 & index < Length) return true;
            return false;
        }
    }

    // Продемонстрировать применение усовершенствованного
    // отказоустойчивого массива.
    class Program_10
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);
            // Использовать свойство Error.
            for (int i = 0; i < fs.Length + 1; i++)
            {
                fs[i] = i * 10;
                if (fs.Error)
                    Console.WriteLine("Ошибка в индексе " + i);
            }

            Console.ReadKey();
        }
    }
}
