/*
 
What are LINQ queries in C#? Give an example.

LINQ (Language Integrated Query) is a powerful feature in C# that allows you to write queries directly 
in C# code. LINQ provides a consistent model for working with data across various sources, 
such as databases, XML documents, and collections.
 
*/

namespace CSharp.Intermediate.LinQ
{

    public class LinqExample
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static string[] names = { "John", "Jane", "Bill" };
        private static int[] ids = { 1, 2, 3 };

        // 1. Where (Filtering)
        public static void FilterEvenNumbers()
        {
            var evenNumbers = numbers.Where(num => num % 2 == 0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
        }

        public static void FilterOddNumbers()
        {
            var oddNumbers = numbers.Where(num => num % 2 != 0);
            Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));
        }

        // 2. Select (Projection)
        public static void GetSquares()
        {
            var squares = numbers.Select(num => num * num);
            Console.WriteLine("Squares: " + string.Join(", ", squares));
        }

        // 3. Zip (Combining two sequences)
        public static void CombineEvenWithSquares()
        {
            var evenNumbers = numbers.Where(num => num % 2 == 0);
            var squares = numbers.Select(num => num * num);

            var combined = evenNumbers.Zip(squares, (even, square) => $"Even: {even}, Square: {square}");
            Console.WriteLine("Combined Even and Squares:\n" + string.Join("\n", combined));
        }

        // 4. OrderBy / OrderByDescending (Sorting)
        public static void SortNumbers()
        {
            var orderedNumbersAsc = numbers.OrderBy(num => num);
            var orderedNumbersDesc = numbers.OrderByDescending(num => num);
            Console.WriteLine("Ascending: " + string.Join(", ", orderedNumbersAsc));
            Console.WriteLine("Descending: " + string.Join(", ", orderedNumbersDesc));
        }

        // 5. GroupBy (Grouping)
        public static void GroupNumbers()
        {
            var groups = numbers.GroupBy(num => num % 2 == 0 ? "Even" : "Odd");

            foreach(var group in groups)
            {
                Console.WriteLine($"{group.Key} Numbers: {string.Join(", ", group)}");
            }
        }

        // 6. Join (Joining two sequences)
        public static void JoinIdsWithNames()
        {
            var joined = ids.Join(
            ids, // First sequence
            id => id, // Key selector for ids
            id => id, // Key selector for names (since ids and names align)
            (id, _) => new { Id = id, Name = names[Array.IndexOf(ids, id)] } // Result selector
            );

            foreach(var item in joined)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
        }

        // 7. Count / Sum / Average (Aggregation)
        public static void AggregateOperations()
        {
            Console.WriteLine($"Count: {numbers.Count()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Average: {numbers.Average()}");
        }

        // 8. First / Last (Element Selection)
        public static void ElementSelection()
        {
            Console.WriteLine($"First: {numbers.First()}");
            Console.WriteLine($"Last: {numbers.Last()}");
        }

        // 9. Distinct (Removing duplicates)
        public static void DistinctNumbers()
        {
            int[] duplicateNumbers = { 1, 2, 2, 3, 3, 4, 5 };
            var distinct = duplicateNumbers.Distinct();
            Console.WriteLine("Distinct Numbers: " + string.Join(", ", distinct));
        }

        // 10. Any / Contains (Checking conditions)
        public static void CheckNumbers()
        {
            bool allEven = numbers.All(num => num % 2 == 0);
            bool containsFive = numbers.Contains(5);
            Console.WriteLine($"Are all numbers even? {allEven}");
            Console.WriteLine($"Does the array contain 5? {containsFive}");
        }

        // 11. ToList / ToArray (Conversion)
        public static void ConvertNumbers()
        {
            var list = numbers.ToList();
            Console.WriteLine("Converted to List: " + string.Join(", ", list));
        }
    }
}
