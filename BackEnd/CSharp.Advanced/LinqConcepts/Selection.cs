using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Selection
    {
        // First / Last (Element Selection)
        public static void ElementSelection()
        {
            Console.WriteLine("\n---- Selection Demo ----\n");

            Console.WriteLine($"First: {SampleData.Numbers.First()}");
            Console.WriteLine($"Last: {SampleData.Numbers.Last()}");
        }
    }
}
