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

        }
    }
}
