/*
     Reversing the string
     Revering the number
     Reversing the word
 
 
 */

namespace CSharp.Coding.Reversing
{
    public static class Reversing
    {
        public static void ReversingTheString() 
        {
            string input = "Nandha";
            char[] inputArray = input.ToCharArray();
            string reverseStr = "";

            for(int i = inputArray.Length - 1; i >=0; i--)
            {
                reverseStr += inputArray[i];
                
            }

            Console.WriteLine(reverseStr);

        }

        public static void ReversingTheNumber()
        {
            int input = 12345678;
            string inputNum = input.ToString();
            string reverseNum = "";

            for(int i = inputNum.Length - 1; i >= 0; i--)
            {
                reverseNum += inputNum[i];
                
            }

            Console.WriteLine(reverseNum);

        }

        public static void ReversingTheWord()
        {
            string word = "I'm Good boy";
            
            string[] splWord = word.Split(' ');

            for(int i = splWord.Length - 1; i >= 0; i--)
            {
                Console.Write(splWord[i]);

                if(i > 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
