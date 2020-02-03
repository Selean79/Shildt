using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class ByTwos : ISeries
    {
        
        int val;
        

        public ByTwos()
        {
        
            val = 0;
        }

        public int Next
        {
            get
            {
                val += 2;
                return val;
            }

            set
            {
                val = value;
            }
        }

       
    }
}
