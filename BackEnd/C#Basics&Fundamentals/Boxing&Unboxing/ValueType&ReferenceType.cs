/*
 
| Feature          | **Boxing**                                      | **Unboxing**                      |
| ---------------- | ----------------------------------------------- | --------------------------------- |
| Meaning          | Converts value type → object type               | Converts object type → value type |
| Happens when     | Assigning value type to `object` or `interface` | Casting object back to value type |
| Cost             | Performance overhead (heap allocation)          | Possible `InvalidCastException`   |
| Automatic/Manual | Automatic                                       | Explicit cast required            |


 */

namespace C_Basics_Fundamentals.Boxing_Unboxing
{
    public class ValueTypeAndReferenceType
    {

        public static void ValueRefTypeOrBoxingUnboxing() 
        {
            // ======= BOXING =======
            int num = 100;              // Value type
            object obj = num;           // Boxing: value type → object
            Console.WriteLine("Boxing:");
            Console.WriteLine($"Value of num: {num}");
            Console.WriteLine($"Value of obj (boxed): {obj}");

            // ======= UNBOXING =======
            int unboxedNum = (int)obj;  // Unboxing: object → value type
            Console.WriteLine("\nUnboxing:");
            Console.WriteLine($"Unboxed value: {unboxedNum}");

            // Changing the unboxed value doesn't affect original object
            unboxedNum = 200;
            Console.WriteLine($"\nModified unboxed value: {unboxedNum}");
            Console.WriteLine($"Original boxed object: {obj}");

        }
    }
}
