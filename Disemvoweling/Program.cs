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
                var str2 = StringPuzzles.Disemvowel(str);
                Console.WriteLine("Disemvoweling: " + str2);
                var str3 = StringPuzzles.AlphabetPosition(str2);
                Console.WriteLine("AlphabetPosition: " + str3);
                var str4 = Convert.ToInt32(str3.Replace(" ", ""));
                Console.WriteLine(NumberPuzzles.Persistence(str4));
            } while (str != "");

            Console.ReadLine();
        }
    }
}
