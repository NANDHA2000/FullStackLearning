/*
 
 Ordered collection, index-based access ([]).
 
 
 */



namespace CSharp.Intermediate.Interfaces
{
    public class IList
    {
        public static void IListDemo()
        {
            IList<int> numbers = new List<int> { 10, 20, 30 };
            numbers.Insert(1, 15); // index-based insert

            foreach(var n in numbers)
                Console.WriteLine(n);

            Console.WriteLine("Item at index 2: " + numbers[2]);
        }
    }
}
