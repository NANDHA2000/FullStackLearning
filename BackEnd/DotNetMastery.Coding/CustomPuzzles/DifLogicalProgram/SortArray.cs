namespace DotNetMastery.Coding.CustomPuzzles.DifLogicalProgram
{
    public class SortArray
    {
        public static void sortarray(int[] arr) 
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }  
    }
}
