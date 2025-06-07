using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding.Rotation
{
    public class RightCircularRotationString
    {
        public void RightCircularRotation() 
        {
            string input = "Nandha";

            char[] arr = input.ToCharArray();

            int n = arr.Length;

            char lastElement = arr[n - 1];

            // Shift elements to the left
            for(int i = n - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            // Move the first element to the last position
            arr[0] = lastElement;

            // Print rotated array
            Console.WriteLine("RIght Rotated Array: " + string.Join(" ", arr));


            // Output : Right Rotated Array: a N a n d h
        }
    }
}
