using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.LargestSmallest
{
    public class ThirdLargestNumber
    {
        public void ThirdLargestNo() 
        {
            int[] arr = { 20, 40, 76, 45, 39 };
            int first = int.MinValue;      // For Min value means changes all place MaxValue
            int second = int.MinValue;     // For Min value means changes all place MaxValue
            int third = int.MinValue;      // For Min value means changes all place MaxValue

            for(int i = 0; i < arr.Length; i++) // Start from the second number
            {
                if(arr[i] > first)
                {
                    third = second;
                    second = first;
                    first = arr[i];
                }
                else if(arr[i] > second && arr[i] != first)
                {
                    third = second;
                    second = arr[i]; // Update second largest
                }
                else if(arr[i] > third && arr[i] != second)
                {
                    third = arr[i];
                }
            }
            //Console.WriteLine("First Largest number is: " + first);
            //Console.WriteLine("Second Largest number is: " + second);
            Console.WriteLine("Third Largest number is: " + third);
        }
    }
}
