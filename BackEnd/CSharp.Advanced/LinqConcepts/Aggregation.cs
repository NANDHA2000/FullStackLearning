using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Aggregation
    {

        // Count / Sum / Average (Aggregation)
        public static void AggregateOperations()
        {
            Console.WriteLine("\n---- AggregateOperations Demo ----\n");
            Console.WriteLine($"Count: {SampleData.Numbers.Count()}");
            Console.WriteLine($"Sum: {SampleData.Numbers.Sum()}");
            Console.WriteLine($"Average: {SampleData.Numbers.Average()}");
        }
    }
}
