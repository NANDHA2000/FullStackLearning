/*
 
Implements IEnumerable
Additional Features:
    Count
    Add
    Remove
    Clear
    Contains
    CopyTo
 
 */

namespace CSharp.Intermediate.Interfaces
{
    public class ICollection
    {

        public void ICollectionDemo() 
        {
            ICollection<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");

            Console.WriteLine("Count: " + fruits.Count);
            fruits.Remove("Apple");

            foreach(var fruit in fruits)
                Console.WriteLine(fruit);
        }
    }
}
