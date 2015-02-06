using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_10
{
    // Превратить переменную ErrFlag в свойство.

    class FailSoftArray
    {
        int[] a; // ссылка на базовый массив
        int len; // длина массива
        bool ErrFlag; // теперь это частная переменная,
        // обозначающая результат последней операции
        // Построить массив заданного размера.
        public FailSoftArray(int size)
        {
            a = new int[size];
            len = size;
        }
        // Свойство Length только для чтения.
        public int Length
        {
            get
            {
                return len;
            }
        }
        // Свойство Error только для чтения.
        public bool Error
        {
            get
            {
                return ErrFlag;
            }
        }

        // Это индексатор для класса FailSoftArray.
        public int this[int index]
        {
            // Это аксессор get.
            get
            {
                if (ok(index))
                {
                    ErrFlag = false;
                    return a[index];

                }
                else
                {
                    ErrFlag = true;
                    return 0;
                }
            }
            // Это аксессор set.
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    ErrFlag = false;
                }
                else ErrFlag = true;
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


    // Продемонстрировать применение отказоустойчивого массива.
    class Program_7
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
