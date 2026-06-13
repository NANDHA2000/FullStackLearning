namespace DotNetMastery.Coding.ArrayLogic.Rotation
{
    public class LeftCircularRotationNumber
    {

        public static void LeftCircularRotation(int[] arr) 
        {
            //int[] arr = { 1, 2, 3, 4, 5 };  // Example array
            int n = arr.Length;

            // Store the first element
            int firstElement = arr[0];

            // Shift elements to the left
            for(int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];  // skipping index 0 Taking the value from index 1 and assigning loop is continuing..
            }

            // Move the first element to the last position
            arr[n - 1] = firstElement;

            // Print rotated array
            Console.WriteLine("Left Rotated Array: " + string.Join(" ", arr));
        }
    }
}
