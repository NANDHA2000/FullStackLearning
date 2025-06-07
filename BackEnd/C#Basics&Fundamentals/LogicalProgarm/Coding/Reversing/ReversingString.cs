using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding.Reversing
{
    public class ReversingString
    {

        public void ReversingInput()
        {
            string input = "Nandha";

            char[] ReversedValue = input.ToCharArray();

            for(int i = ReversedValue.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ReversedValue[i]);
            }


            // Output : ahdnaN

        }



        #region Inbuild Function
        public void ReversingInput(string input)
        {

            //Inbuild Function

            char[] charArray = input.ToCharArray(); // Convert string to a char array
            Array.Reverse(charArray); // Reverse the char array
            string reversedvalue1 = new string(charArray); // Convert back to a string

            Console.WriteLine($"Reversed number from Inbuild function: {reversedvalue1}");

        }

        #endregion



        #region Another Approach
        /*char[] reversedArray = new char[input.Length]; // 6
            int j = 0;

            for(int i = input.Length - 1; i >= 0; i--)
            {
                reversedArray[j] = input[i];
                j++;
            }
            string reversedvalue2 = new string(reversedArray);

            Console.WriteLine($"Reversed number from Outbuild function: {reversedvalue2}"); */
        #endregion

    }
}
