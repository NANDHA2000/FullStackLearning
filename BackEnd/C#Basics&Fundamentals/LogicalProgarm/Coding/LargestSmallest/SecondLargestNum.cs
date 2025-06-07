using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding.LargestSmallest
{
    public class SecondLargestNum
    {

        public void FindSecondLargest(int[] arr)
        {
            int first = arr[0];  // Assume first number is the largest
            int second = arr[0]; // Assume first number is the second largest

            for(int i = 0; i < arr.Length; i++) // Start from the second number
            {
                if(arr[i] > first)  // Found a new largest number
                {
                    second = first;  // Previous largest becomes second largest
                    first = arr[i];  // Update largest
                }
                else if(arr[i] > second) // Found a number bigger than second but smaller than first
                {
                    second = arr[i]; // Update second largest
                }
            }

            Console.WriteLine("Second Largest number is: " + second);
        }



        #region Another Approach
        public void FindSecondLargestNum(int[] arr)
        {
            int[] arr1 = { 20, 40, 76, 45, 39 };
            int largest = int.MinValue,
            secondLargest = int.MinValue;

            foreach(int num in arr1)
            {
                if(num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if(num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }

            Console.WriteLine($"Second Largest number is : {secondLargest}");
        }

        public void FindSecondSmallest(int[] arr)
        {
            int smallest = int.MaxValue,
            secondSmallest = int.MaxValue;

            foreach(int num in arr)
            {
                if(num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if(num < secondSmallest && num > smallest)
                {
                    secondSmallest = num;
                }
            }

            Console.WriteLine($"Second Largest number is : {secondSmallest}");
        }
        #endregion

    }
}
