#region Non-Generic Collections
/*

Non-Generic Collections

    * Can store any type (int, string, object, etc.)

    * Not type-safe → prone to runtime errors

    * Boxing/Unboxing occurs for value types (slower)

    * Used in older .NET code

    * Namespace -- System.Collections

*/
#endregion


using System.Collections;

namespace DotNetMastery.Intermediate.Collections
{
    public class NonGeneric
    {
        #region Array
        public static Array Array()
        {
            // 1. Standard Array Initialization (Contiguous block of memory, fixed size)
            int[] numbers = new int[5] { 40, 10, 50, 20, 30 };

            // Access & Update via Index
            int firstElement = numbers[0]; // 40
            numbers[3] = 25;               // Updates 20 to 25

            // Built-in Static Methods on System.Array
            System.Array.Sort(numbers);     // Ascending sort: [10, 25, 30, 40, 50]
            System.Array.Reverse(numbers);  // Reverse order:  [50, 40, 30, 25, 10]

            // Search Methods
            int indexOf30 = System.Array.IndexOf(numbers, 30);      // Returns index of element
            bool exists = System.Array.Exists(numbers, x => x > 40); // Checks condition

            // Array Properties
            int totalItems = numbers.Length; // 5
            int dimensions = numbers.Rank;   // 1 (Single-dimensional)

            // Iteration
            Console.WriteLine("Array Elements:");
            foreach (var num in numbers)
            {
                Console.WriteLine($"Number: {num}");
            }

            // 2. Object Array (Demonstrates non-generic behavior storing mixed types with boxing)
            object[] mixedArray = new object[] { 101, "DotNet", true, 3.14 };

            Console.WriteLine("\nMixed Object Array:");
            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.WriteLine($"Index {i}: {mixedArray[i]} (Type: {mixedArray[i].GetType().Name})");
            }

            return numbers;
        }

        #endregion

        #region ArrayList
        public static ArrayList ArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("hello");
            list.Add(3.14);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            return list;
        }
        #endregion


        #region Hashtable
        public static Hashtable Hashtable()
        {
            Hashtable table = new Hashtable();
            table.Add(1, "One");
            table.Add(2, "Two");
            table.Add(3, "Three");
            table.Add("3", "Three");

            foreach(var item in table)
            {
                Console.WriteLine(item);
            }

            return table;
        }

        #endregion


        #region SortedList
        public static SortedList SortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("2", "Beta");
            sortedList.Add("1", "Alpha");

            foreach(DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }

            return sortedList;
        }
        #endregion


        // Stack and Queue check in Generic it will come both Generic and Non Generic 

    }
}
