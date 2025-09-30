using CSharp.Coding.CountOccurence;
using CSharp.Coding.Duplicate;
using CSharp.Coding.FibonacciSeries;
using CSharp.Coding.Palindrome;
using CSharp.Coding.Reversing;


namespace CSharpLearning.RunFile
{
    public class RunCSharpCoding
    {

        //LogicalProgram
        public static void RunLogicalProgram()
        {
            Console.WriteLine("*** Count Numbers and Strings ***");
            CountOccurenceNumber.CountNumberOccurence();
            Console.WriteLine("");
            CountOccurenceString.CountStringOccurence();
            Console.WriteLine("");
            CountOccurenceString.CountStringOccurenceLinq();
            Console.WriteLine("");

            PalindromeNumber.IsPalindromeNo();
            PalindromeString.IsPalindrome();

            ReversingString.ReversingInput();
            ReversingNumber.ReversingNumbers();
            Reversing.ReverseTheOrderOfWords();

            FibonacciSeries.FibonacciSeriesEx();


            Console.WriteLine("*** Duplicate Numbers and Strings ***");
            DuplicateFromString.DuplicateFromStringEx();
            Console.WriteLine("");
            DuplicateFromString.DuplicateFromStringLinq();
            Console.WriteLine("");
        }
    }
}
