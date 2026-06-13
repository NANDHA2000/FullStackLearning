namespace DotNetMastery.Coding.ArrayLogic.Rotation
{
    public class LeftCircularRotationString
    {

        public static void LeftCircularRotation(string input) 
        {
           // string input = "Nandha";

            char[] arr = input.ToCharArray();

            int n = arr.Length;

            char firstElement = arr[0];

            // Shift elements to the left
            for(int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            // Move the first element to the last position
            arr[n - 1] = firstElement;

            // Print rotated array
            Console.WriteLine("Left Rotated Array: " + string.Join(" ", arr));

        }

        // Output : Left Rotated Array: a n d h a N
    }
}
