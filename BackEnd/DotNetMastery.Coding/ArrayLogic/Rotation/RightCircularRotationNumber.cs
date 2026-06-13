namespace DotNetMastery.Coding.ArrayLogic.Rotation
{
    public class RightCircularRotationNumber
    {

        public static void RightCirularRotation(int[] arr) 
        {

            //int[] arr = { 1, 2, 3, 4, 5 };  // Example array

            int n = arr.Length;
            // Store the first element
            int lastElement = arr[n - 1];

            // Shift elements to the left
            for(int i = n - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            // Move the first element to the last position
            arr[0] = lastElement;

            // Print rotated array
            Console.WriteLine("Right Rotated Array: " + string.Join(" ", arr));
        }


    }
}
