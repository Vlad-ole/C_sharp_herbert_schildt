using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12.Program_1
{
    public interface ISeries
    {
        int GetNext(); // возвратить следующее по порядку число
        void Reset(); // перезапустить
        void SetStart(int х); // задать начальное значение
    }
}
