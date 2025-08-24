using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.Duplicate
{
    public static class DuplicateFromString
    {

        public static void DuplicateFromStringEx() 
        {
            string input = "welcome to programming world, everything you can imagine is real";  // Example string

            string lowercase = input.ToLower();

            for(char c = 'a'; c <= 'z'; c++)
            {
                int count = 0;
                for(int i = 0; i < lowercase.Length; i++)
                {
                    if(lowercase[i] == c)
                    {
                        count++;  // Increment count if character matches
                    }
                }
                if(count > 1)
                {
                    Console.WriteLine($"{c} – {count}");  // Print the letter and its count
                }
            }

        }


        public static void DuplicateFromStringLinq() 
        {
            string input = "welcome to programming world, everything you can imagine is real";

            var duplicates = input
            .ToLower()
            //.Where(char.IsLetter)                   // consider only letters
            .GroupBy(c => c)                        // group by character
            .Where(g => g.Count() > 1)              // only duplicates
            .Select(g => new { Char = g.Key, Count = g.Count() });

            foreach(var item in duplicates)
            {
                Console.WriteLine($"{item.Char} – {item.Count}");
            }
        }

        #region Another Approach
        /*public static void DuplicateFromStringEx() 
        {
            string input = "welcome to programming world, everything you can imagine is real";

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char c in input)
            {
                if(charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            Console.WriteLine(" ");

            // Now print characters that appear more than once (duplicates)
            Console.WriteLine("Duplicate characters and their counts:");

            foreach(var kvp in charCount.Where(kvp => kvp.Value > 1))
            {
                Console.WriteLine($"Character '{kvp.Key}' appears {kvp.Value} times.");
            }

        }*/
        #endregion
    }
}
