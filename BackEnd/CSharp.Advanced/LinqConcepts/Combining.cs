using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Combining
    {
        // Zip (Combining two sequences)
        public static void CombineEvenWithSquares()
        {
            Console.WriteLine("\n---- Combining Demo ----\n");
            var evenNumbers = SampleData.Numbers.Where(num => num % 2 == 0);
            var squares = SampleData.Numbers.Select(num => num * num);

            var combined = evenNumbers.Zip(squares, (even, square) => $"Even: {even}, Square: {square}");
            Console.WriteLine("Combined Even and Squares:\n" + string.Join("\n", combined));
        }
    }
}
