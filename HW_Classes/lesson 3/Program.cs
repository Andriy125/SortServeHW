using System;

namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Loren ipusm str hello c sharp and others";
            string[] str_split = str.Split(" ");
            int lenght_str = str_split.Length;
            Console.WriteLine($"lenght str; {lenght_str}");

            int longer_word = 0;
            foreach (var item in str_split)
            {
                char[] char_array = item.ToCharArray();
                int lenght_word = char_array.Length;
                if (longer_word > lenght_word)
                {
                    lenght_word = longer_word;
                }
            }
            Console.WriteLine($"longer_word has a {longer_word} keys");

            
        }
    }
}
