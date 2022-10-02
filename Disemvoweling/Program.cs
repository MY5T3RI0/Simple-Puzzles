using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweling
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Enter string for Disemvoweling");
                str = Console.ReadLine();
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

                Console.WriteLine(str);
            } while (str != "");

            Console.ReadLine();
        }
    }
}
