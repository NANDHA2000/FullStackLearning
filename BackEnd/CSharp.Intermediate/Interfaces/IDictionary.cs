namespace CSharp.Intermediate.Interfaces
{
    public class IDictionary
    {
        public static void IDictionaryDemo()
        {
            IDictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "Alice");
            employees.Add(2, "Bob");

            foreach(var kvp in employees)
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }

    }
}
