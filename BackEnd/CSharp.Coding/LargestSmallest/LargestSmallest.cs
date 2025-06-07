using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.LargestSmallest
{
    public class LargestSmallest
    {
        public void FindLargestAndSmallest(int[] numbers)
        {

            int largest;
            int smallest;

            if(numbers.Length == 1)
            {
                numbers = [23, 50, 30, 200, 3000];
            }

            largest = numbers.Max(); // Built-in function to find the maximum
            smallest = numbers.Min(); // Built-in function to find the minimum

            Console.WriteLine($"Largest number (using built-in): {largest}");
            Console.WriteLine($"Smallest number (using built-in): {smallest}");



            largest = int.MinValue; // Initialize to smallest possible value
            smallest = int.MaxValue; // Initialize to largest possible value

            foreach(int num in numbers)
            {
                if(num > largest)
                    largest = num;

                if(num < smallest)
                    smallest = num;
            }

            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Smallest number: {smallest}");
        }

    }
}
