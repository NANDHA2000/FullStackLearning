namespace CSharp.Intermediate.Interfaces
{
    public class IQueryable
    {
        public static void IQueryableDemo()
        {
            IQueryable<int> queryable = new List<int> { 1, 2, 3, 4, 5 }.AsQueryable();
            var result = queryable.Where(x => x > 2);

            foreach(var r in result)
                Console.WriteLine(r);
        }
    }
}
