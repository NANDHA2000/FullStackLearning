using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Filtering
    {
        // Where (Filtering)

        public static void FilteringNumbers()
        {
            Console.WriteLine("\n---- Filtering Demo ----\n");
            FilterEvenNumbers();
            FilterOddNumbers();
        }

        public static void FilterEvenNumbers()
        {
            var evenNumbers = SampleData.Numbers.Where(num => num % 2 == 0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
        }

        public static void FilterOddNumbers()
        {
            var oddNumbers = SampleData.Numbers.Where(num => num % 2 != 0);
            Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));
        }
    }
}
