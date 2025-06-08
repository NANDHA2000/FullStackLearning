using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.DifLogicalProgram
{
    public class FirstNonRepeat
    {

        public void FindFirstNonRepeatingChar(string input)
        {

            /*string lowerInput = input.ToLower(); // It will convert input to lower
            string upperInput = input.ToUpper(); // It will convert input to upper*/

            for(int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int count = 0;

                // Count occurrences of the current character in the string
                for(int j = 0; j < input.Length; j++)
                {
                    if(input[j] == currentChar)
                    {
                        count++;
                    }
                }

                // If the character occurs only once, print it and exit the loop
                if(count == 1)
                {
                    Console.WriteLine(currentChar);
                    return;  // Exit the method after printing the first non-repeating character
                }
            }

            Console.WriteLine("No non-repeating character found.");

        }


        public void FindFirstNonRepeatingNumber(int[] numbers) 
        {
            //int[] numbers = { 1, 2, 3, 4, 1 };
            for(int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                int count = 0;

                // Count occurrences of the current number in the array
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[j] == currentNum)
                    {
                        count++;
                    }
                }

                // If the number occurs only once, print and exit
                if(count == 1)
                {
                    Console.WriteLine($"First non-repeating number: {currentNum}");
                    return;
                }
            }

            Console.WriteLine("No non-repeating number found.");
        }

    }
}
