using CSharp.Coding.CountOccurence;
using CSharp.Coding.Duplicate;
using CSharp.Coding.FibonacciSeries;
using CSharp.Coding.Palindrome;
using CSharp.Coding.Reversing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.RunFile
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
