using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweling
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            string VOWELS = "AEIOUaeiou";
            foreach (var item in str)
            {
                foreach (var item2 in VOWELS)
                {
                    if (item == item2)
                    {
                        str = str.Replace(item.ToString(), "");
                    }
                }
            }
            return str;
        }
    }
}
