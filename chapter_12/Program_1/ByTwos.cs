using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_12.Program_1
{
    class ByTwos : ISeries
    {
        int start;
        int val;
        
        public ByTwos()
        {
            start = 0;
            val = 0;
        }
        
        public int GetNext()
        {
            val += 2;
            return val;
        }
        
        public void Reset()
        {
            val = start;
        }
        
        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
}
