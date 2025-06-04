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

namespace CSharp.Intermediate.Collections
{
    public class NonGeneric
    {
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
