using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Projection
    {
        // Select (Projection)
        public static void GetSquares()
        {
            Console.WriteLine("\n---- Projection Demo ----\n");

            var squares = SampleData.Numbers.Select(num => num * num);
            Console.WriteLine("Squares: " + string.Join(", ", squares));
        }
    }
}
