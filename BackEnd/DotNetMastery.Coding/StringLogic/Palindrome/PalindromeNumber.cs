namespace DotNetMastery.Coding.StringLogic.Palindrome
{
    public class PalindromeNumber
    {

        public static void IsPalindromeNo()
        {
            int InputNumber = 1234321;

            string ReversedStr = InputNumber.ToString();

            string ReversedNumber = "";

            for(int i = ReversedStr.Length - 1; i >= 0; i--)
            {
                //Console.Write(ReversedStr[i]);
                ReversedNumber = ReversedNumber + ReversedStr[i];
                Console.WriteLine();
            }

            Console.WriteLine("Reversed Number: " + ReversedNumber);

            if(ReversedNumber == ReversedStr)
            {
                Console.WriteLine("Input is Palindrome");
            }

            else
            {
                Console.WriteLine("Input is not Palindrome");
            }

        }

        #region Another Approach
        /*int num = 123456;
int original = num, reversed = 0;

while(num > 0)
{
    int digit = num % 10; // Extract last digit
    reversed = reversed * 10 + digit; // Build reversed number
    num /= 10; // Remove last digit
}

//return original == reversed; // Compare original and reversed numbers*/
        #endregion
    }
}
