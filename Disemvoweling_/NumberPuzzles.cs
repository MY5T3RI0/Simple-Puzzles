using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    public static class NumberPuzzles
    {
        public static int Persistence(long n)
        {
            var result = 0;
            while (n / 10 != 0)
            {
                var multiple = 1L;
                for (int i = n.ToString().Length; i > 0; i--)
                {
                    multiple *= (long)(n / Math.Pow(10, i-1) % 10);
                }
                n = (long)multiple;
                result++;
            }
            return result;
        }
    }
}
