using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Ordering
    {
        // OrderBy / OrderByDescending (Sorting)
        public static void SortNumbers()
        {
            Console.WriteLine("\n---- Ordering Demo ----\n");

            var orderedNumbersAsc = SampleData.Numbers.OrderBy(num => num);
            var orderedNumbersDesc = SampleData.Numbers.OrderByDescending(num => num);
            Console.WriteLine("Ascending: " + string.Join(", ", orderedNumbersAsc));
            Console.WriteLine("Descending: " + string.Join(", ", orderedNumbersDesc));
        }
    }
}
