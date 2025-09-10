using static CSharp.CommonUtils.Database.PersonDatabase;

namespace CSharp.Advanced.LinqConcepts
{
    public class Join
    {
        // Join (Joining two sequences)
        public static void JoinIdsWithNames()
        {
            Console.WriteLine("\n---- Join Demo ----\n");

            var joined = SampleData.Ids.Join(
            SampleData.Ids, // First sequence
            id => id, // Key selector for ids
            id => id, // Key selector for names (since ids and names align)
            (id, _) => new { Id = id, Name = SampleData.Names[Array.IndexOf(SampleData.Ids, id)] } // Result selector
            );

            foreach(var item in joined)
            {
                Console.WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }
        }
    }
}
