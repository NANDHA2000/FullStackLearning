using DotNetMastery.Coding.ArrayLogic.LargestSmallest;
using DotNetMastery.Coding.ArrayLogic.Rotation;
using DotNetMastery.Coding.BasicLogic;
using DotNetMastery.Coding.BasicLogic.Patterns;
using DotNetMastery.Coding.CustomPuzzles.DifLogicalProgram;
using DotNetMastery.Coding.CustomPuzzles.Duplicate;
using DotNetMastery.Coding.CustomPuzzles.ProblemStatementProgram;
using DotNetMastery.Coding.StringLogic.CountOccurence;
using DotNetMastery.Coding.StringLogic.Palindrome;
using DotNetMastery.Coding.StringLogic.Reversing;
using DotNetMastery.CommonUtils.Database.DotNetMastery.CommonUtils.DataSources;
using DotNetMastery.CommonUtils.Database.LinQ;

namespace DotNetMastery.RunFile
{
    public class RunDotNetMasteryCoding
    {

        //LogicalProgram
        public static void RunLogicalProgram()
        {

            #region ArrayLogic
            //largest and smallest number in an array

            LargestSmallest.FindLargestAndSmallest(ArrayDataSource.GetUnsortedArray());
            SecondLargestNum.FindSecondLargest(ArrayDataSource.GetUnsortedArray());
            ThirdLargestNumber.ThirdLargestNo(ArrayDataSource.GetUnsortedArray());

            //Rotation of an array
            RightCircularRotationString.RightCircularRotation(StringDataSource.GetSimpleString());
            LeftCircularRotationString.LeftCircularRotation(StringDataSource.GetSimpleString());

            RightCircularRotationNumber.RightCirularRotation(ArrayDataSource.GetSimpleArray());
            LeftCircularRotationNumber.LeftCircularRotation(ArrayDataSource.GetSimpleArray());
            #endregion


            #region BasicLogic
            //Patterns
            RightAngleTrianglePattern.RightAngleTriangle();

            //Fibonacci Series
            FibonacciSeries.FibonacciSeriesEx();

            //Swapping two values
            SwappingTwoValues.SwapTwoNumbers();
            SwappingTwoValues.SwapTwoStrings();
            #endregion


            #region CustomPuzzles
            //Custom Puzzles
            DuckNumOrNot.DuckNumberOrNot();
            Factorial.factorial(5);
            FirstNonRepeat.FindFirstNonRepeatingChar(StringDataSource.GetSimpleString());
            FizzBuzz.FizzBuzzz();
            IsPrimeNumber.IsPrimeOrNot();
            Matrix.DisplayMatrix(ArrayDataSource.GetSimpleArray(), 3, 3);
            RemoveDuplicate.RemoveDupFromArray(ArrayDataSource.GetArrayWithDuplicates());
            SortArray.sortarray(ArrayDataSource.GetUnsortedArray());
            SumOfPositiveNumber.SumOfPositiveNumbers();

            //Duplicate from string
            DuplicateFromString.DuplicateFromStringEx();

            //Matrix traversal
            MatrixTransversal.DirectionalPatternMatchInGrid();
            #endregion


            #region StringLogic
            CountOccurenceNumber.CountNumberOccurence();
            CountOccurenceString.CountStringOccurence();

            PalindromeNumber.IsPalindromeNo();
            PalindromeString.IsPalindrome();

            ReversingString.ReversingInput();
            ReversingNumber.ReversingNumbers();
            Reversing.ReverseTheOrderOfWords(); 
            #endregion

        }
    }
}
