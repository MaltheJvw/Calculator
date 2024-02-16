using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    class Counter
    {
        private static int Count;
        public static void Increment()
        {
            Count++;
        }
        public static void Reset()
        {
            Count = 0;
        }

        
        public static int GetCount()
        {
            return Count;
        }

    }
}
