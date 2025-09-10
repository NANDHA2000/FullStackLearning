/*
 
IEnumerable → supports foreach iteration.

IEnumerator → represents the enumerator itself.
 
*/



namespace CSharp.Intermediate.Interfaces
{
    public class IEnumerable
    {
        public void IEnumerableAndEnumeratorDemo() 
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            // IEnumerable<T>
            IEnumerable<int> enumerable = numbers;
            foreach(var num in enumerable)
                Console.WriteLine(num);

            // IEnumerator<T>
            IEnumerator<int> enumerator = numbers.GetEnumerator();
            while(enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);
        }
    }
}
