namespace CSharp.Advanced.LinqConcepts
{
    public class DistinctElements
    {
        // Distinct (Removing duplicates)
        public static void DistinctNumbers()
        {
            Console.WriteLine("\n---- Distinct Elements Demo ----\n");
            int[] duplicateNumbers = { 1, 2, 2, 3, 3, 4, 5 };
            var distinct = duplicateNumbers.Distinct();
            Console.WriteLine("Distinct Numbers: " + string.Join(", ", distinct));
        }
    }
}
