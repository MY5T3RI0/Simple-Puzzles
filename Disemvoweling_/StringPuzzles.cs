using System;

namespace Puzzles
{
    public static class StringPuzzles
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

        public static string AlphabetPosition(string text)
        {
            text = text.ToLower();
            string result = "";
            foreach (var symb in text)
            {
                if (symb > 96 && symb <= 122)
                    result += ((int)symb - 96).ToString() + " ";
            }
            return !string.IsNullOrWhiteSpace(result) ? result.Substring(0, result.Length - 1) : "";
        }
    }
}
