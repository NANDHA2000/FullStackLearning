using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Conversion
    {
        // ToList / ToArray (Conversion)
        public static void ConvertNumbers()
        {
            Console.WriteLine("\n---- Conversion Demo ----\n");
            var list = SampleData.Numbers.ToList();
            Console.WriteLine("Converted to List: " + string.Join(", ", list));
        }
    }
}
