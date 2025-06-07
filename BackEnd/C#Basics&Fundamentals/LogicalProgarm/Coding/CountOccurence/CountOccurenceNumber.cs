using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding.CountOccurence
{
    public class CountOccurenceNumber
    {

        public void CountNumberOccurence() 
        {
            int inputNumber = 1234512345;  // Example number

            // Convert the integer to a string to process each digit
            string input = inputNumber.ToString();

            // Loop through each digit (0-9)
            for(char c = '0'; c <= '9'; c++)
            {
                int count = 0;
                // Loop through the string representation of the number to count occurrences of the current digit
                for(int i = 0; i < input.Length; i++)
                {
                    if(input[i] == c)
                    {
                        count++;  // Increment count if character matches
                    }
                }
                if(count > 0)
                {
                    Console.WriteLine($"{c} – {count}");  // Print the digit and its count
                }
            }

            /* Output : 1 - 2
                        2 - 2
                        3 - 2
                        4 - 2
                        5 - 2
            */
        }
    }
}
