using System;
using Puzzles;

namespace TestCL
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Enter string");
                str = Console.ReadLine();
                Console.WriteLine("Disemvoweling: " + Kata.Disemvowel(str));
                Console.WriteLine("AlphabetPosition: " + Kata.AlphabetPosition(str));
            } while (str != "");

            Console.ReadLine();
        }
    }
}
