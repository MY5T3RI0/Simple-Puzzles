using System;
using Disemvoweling;

namespace TestCL
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
                Console.WriteLine(Kata.Disemvowel(str));
            } while (str != "");

            Console.ReadLine();
        }
    }
}
