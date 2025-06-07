using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding.CountOccurence
{
    public class CountOccurenceString
    {

        public void CountStringOccurence() 
        {
            string input = "NANDHA";  // Example string

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
                if(count > 0)
                {
                    Console.WriteLine($"{c} – {count}");  // Print the letter and its count
                }
            }

            /* Output : n - 2
                        a - 2
                        d - 1
                        h - 1
            */
        }
    }
}
