using DotNetMastery.Coding.CountOccurence;
using DotNetMastery.Coding.Duplicate;
using DotNetMastery.Coding.FibonacciSeries;
using DotNetMastery.Coding.Palindrome;
using DotNetMastery.Coding.Reversing;

namespace DotNetMastery.RunFile
{
    public class RunCSharpCoding
    {

        //LogicalProgram
        public static void RunLogicalProgram()
        {

            CountOccurenceNumber.CountNumberOccurence();
            CountOccurenceString.CountStringOccurence();

            PalindromeNumber.IsPalindromeNo();
            PalindromeString.IsPalindrome();

            ReversingString.ReversingInput();
            ReversingNumber.ReversingNumbers();
            Reversing.ReverseTheOrderOfWords();

            FibonacciSeries.FibonacciSeriesEx();



            DuplicateFromString.DuplicateFromStringEx();
        }
    }
}
