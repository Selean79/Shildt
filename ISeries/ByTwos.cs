using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISeries
{
    class ByTwos : ISeries
    {
        int start;
        int val;
        int prev;

        public  ByTwos()
        {
            start = 0;
            val = 0;
            prev = -2;
        }

        public int GetNext()
        {
            prev = val;
            val += 2;
            return val;
        }

        public void Reset()
        {
            val = start;
            prev = start - 2;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
            prev = val - 2;
        }

        public int GetPrevious()
        {
            return prev;
        }
    }
}
