using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Grouping
    {
        // GroupBy (Grouping)
        public static void GroupNumbers()
        {
            Console.WriteLine("\n---- Grouping Demo ----\n");

            var groups = SampleData.Numbers.GroupBy(num => num % 2 == 0 ? "Even" : "Odd");

            foreach(var group in groups)
            {
                Console.WriteLine($"{group.Key} Numbers: {string.Join(", ", group)}");
            }
        }
    }
}
