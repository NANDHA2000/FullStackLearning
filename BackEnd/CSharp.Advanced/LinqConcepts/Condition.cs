using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Condition
    {
        // Any / Contains (Checking conditions)
        public static void CheckNumbers()
        {
            Console.WriteLine("\n---- Condition Demo ----\n");
            bool allEven = SampleData.Numbers.All(num => num % 2 == 0);
            bool containsFive = SampleData.Numbers.Contains(5);
            Console.WriteLine($"Are all numbers even? {allEven}");
            Console.WriteLine($"Does the array contain 5? {containsFive}");
        }
    }
}
