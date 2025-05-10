#region Collection In C# -- Defintion

/* Collection In C#

********** In C#, collections are classes that are used to store, manage, and manipulate groups of related objects. 
********** They are part of the System.Collections, System.Collections.Generic, and System.Collections.Concurrent namespaces.


Types of Collections in C#

   1. Non-Generic Collections (from System.Collections)
        Store elements as object (boxing/unboxing needed)

             Examples:

             ArrayList – dynamic array

             Hashtable – key-value pair storage

             Stack – LIFO

             Queue – FIFO

   2. Generic Collections (from System.Collections.Generic)
        Type-safe and more performant

             Examples:

             List<T> – dynamic array

             Dictionary<TKey, TValue> – key-value pairs

             HashSet<T> – unique elements

             Queue<T> – FIFO

             Stack<T> – LIFO

             SortedList<TKey, TValue> – sorted by key

   3. Concurrent Collections (for multithreaded scenarios)

             Examples:

             ConcurrentDictionary<TKey, TValue>

             ConcurrentQueue<T>

             ConcurrentStack<T>



*/
#endregion



#region Generic Collections
/*  Generic Collections

* Introduced in .NET 2.0

* Store only one specific data type

* Type-safe, faster, better performance

* Recommended for modern development

* Namespace -- System.Collections.Generic

*/
#endregion


namespace C_DotNetLearning.Collections
{
    public class Generic
    {

        #region List
        // Generic Collection -- List
        public static List<int> List()
        {
            List<int> list = new List<int>() { 1, 20, 50, 2, 100 };

            // Add elements

            list.Add(500);    // Add new integer value in list
            list.AddRange(new List<int> { 21, 22 });  //Add new elements as a collection to the list

            // Insert elements
            list.Insert(0, 999);                              // Insert at index 0
            list.InsertRange(2, new List<int> { 300, 400 });  // Insert a range at index 2

            // Remove elements
            list.Remove(21);
            list.RemoveAt(0); // Remove integer value from the list based on index
            list.RemoveRange(0, 1);
            // Safe removal using condition (e.g., remove even numbers)
            list.RemoveAll(x => x % 2 != 0);          // Remove all even numbers


            // Search
            bool contains100 = list.Contains(100);    // Check if 100 exists
            int indexOf50 = list.IndexOf(50);         // Get index of 50


            // Sort & Reverse
            list.Sort();                              // Ascending sort
            list.Reverse();                           // Reverse list order

            // Access
            int count = list.Count;                   // Number of items
            int firstItem = list[0];                  // Get item by index

            // Clear list (optional demonstration)
            // list.Clear();


            foreach(int item in list)
            {
                Console.WriteLine($"List Of Numbers : {item}");
            }

            return list;
        }
        #endregion

        #region Dictionary
        // Generic Collection -- Dictionary
        public static Dictionary<int, string> Dictionary()
        {
            // Creating a dictionary with employee ID as key and name as value
            Dictionary<int, string> employees = new Dictionary<int, string>() { { 100, "Nandha" } };

            // Add elements
            employees.Add(101, "John");
            employees.Add(102, "Jane");
            employees[103] = "Bob";  // Alternative way to add

            // Update value
            employees[102] = "Janet";  // Overwrites "Jane"

            // ContainsKey & ContainsValue
            bool hasKey = employees.ContainsKey(101);     // true
            bool hasValue = employees.ContainsValue("Bob"); // true

            // Remove element
            employees.Remove(103); // Removes Bob

            // TryGetValue - Safe access
            if(employees.TryGetValue(101, out string? empName))
            {
                Console.WriteLine($"Employee 101: {empName}");
            }

            // Iterating the dictionary
            Console.WriteLine("Employee List:");

            foreach(KeyValuePair<int, string> emp in employees)
            {
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
            }

            return employees;
        }
        #endregion

        #region HashSet
        // Generic Collection -- HashSet
        public static HashSet<int> HashSet()
        {
            HashSet<int> numbers = new HashSet<int>();

            // Add elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(10);  // Duplicate - will be ignored

            // AddRange equivalent: UnionWith
            numbers.UnionWith(new List<int> { 40, 50, 10 }); // 10 is ignored again

            // Remove
            numbers.Remove(20);

            // Contains
            bool has30 = numbers.Contains(30); // true

            // Count
            Console.WriteLine($"Total Unique Numbers: {numbers.Count}");

            // Iteration
            Console.WriteLine("HashSet Contents:");
            foreach(int number in numbers)
            {
                Console.WriteLine("Numbers : " + number);
            }

            return numbers;
        }
        #endregion

        #region Queue
        public static Queue<string> Queue()
        {
            Queue<string> queue = new Queue<string>(new[] { "Queue 4", "Queue 5" });

            queue.Enqueue("Queue 1");
            queue.Enqueue("Queue 2");
            queue.Enqueue("Queue 3");                                                                 // First In First Out

            Console.WriteLine($"First of the queue: {queue.Peek()}");  // Return the beginning of the queue

            while(queue.Count > 0)
            {
                Console.WriteLine($"Going back to queue : {queue.Dequeue()}");  // Remove from beginning of the queue
            }

            return queue;
        }
        #endregion

        #region SortedDictionary
        public static SortedDictionary<int, string> SortedDictionary()
        {
            SortedDictionary<int, string> departments = new SortedDictionary<int, string>() { { 5, "Dev" }, { 4, "QA" } };

            departments.Add(3, "Finance");
            departments.Add(1, "HR");
            departments.Add(2, "IT");

            foreach(var dept in departments)
            {
                Console.WriteLine($"Dept ID: {dept.Key}, Name: {dept.Value}");
            }

            return departments;
        }
        #endregion

        #region Stack
        public static Stack<string> Stack()   // Last In First Out
        {
            Stack<string> stack = new Stack<string>(new[] { "Stack 4", "Stack 5" });

            bool data = stack.Contains("Stack 6");
            Console.WriteLine($"data : {data}");

            stack.Clear();  // Remove all object from the stack

            stack.Push("Stack 1");
            stack.Push("Stack 2");
            stack.Push("Stack 3");

            Console.WriteLine($"Top of stack: {stack.Peek()}");  // Return the top of the stack

            while(stack.Count > 0)            // Count -- Gets the total number of items                  
            {
                Console.WriteLine($"Going back to stack : {stack.Pop()}"); // Remove from top of the stack
            }

            return stack;
        } 
        #endregion

    }
}
