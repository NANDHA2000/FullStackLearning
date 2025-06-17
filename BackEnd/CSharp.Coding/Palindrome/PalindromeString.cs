using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.Palindrome
{
    public class PalindromeString
    {

        public static void IsPalindrome()
        {
            string? OriginalInput = "Madam";

            string? ReversedInput = "";

            string LowerInput = OriginalInput.ToLower();

            //char[] ReversedValue = OriginalInput.ToCharArray();

            for(int i = LowerInput.Length - 1; i >= 0; i--)
            {
                ReversedInput += LowerInput[i];

            }

            //Console.Write(ReversedInput);

            if(ReversedInput == LowerInput)
            {
                Console.WriteLine("Input is Palindrome");
            }
            else
            {
                Console.WriteLine("Input is not Palindrome");
            }

            
        }

        #region Another Approach
        /*            string str = "nandha";
                        int left = 0, right = str.Length - 1;

                        while(left < right)
                        {
                            if(char.ToLower(str[left]) != char.ToLower(str[right]))
                                Console.WriteLine("input is not palandrome");
                            left++;
                            right--;
                            return;
                        }

                        Console.WriteLine("input is palandrome");*/
        #endregion

    }
}
