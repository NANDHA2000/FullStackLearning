/*

✅ What is Type Casting in C#?

Type Casting is the process of converting a variable from one data type to another.

🔀 Types of Type Casting

1. Implicit Casting (Safe/Automatic Conversion)
Automatically done by the compiler.

Happens when there is no risk of data loss.

Converts smaller to larger data types.

--- char -> int -> long -> float -> double


2. Explicit Casting (Manual Conversion)
Done manually by the programmer using a cast operator.

Required when converting larger to smaller types or incompatible types.

May result in data loss.

 --- double -> float -> long -> int -> char


------------------------------------------------------------

| Casting Type     | Direction            | Requires Cast | Risk of Data Loss | Example        |
| ---------------- | -------------------- | ------------- | ----------------- | -------------- |
| Implicit Casting | Small → Large type   | ❌ No          | ❌ No              | `int → float`  |
| Explicit Casting | Large → Small type   | ✅ Yes         | ✅ Yes             | `float → int`  |
| Upcasting        | Derived → Base class | ❌ No          | ❌ No              | `Dog → Animal` |
| Downcasting      | Base → Derived class | ✅ Yes         | ✅ Yes (if wrong)  | `Animal → Dog` |



 */

namespace C_Basics_Fundamentals.Casting
{
    public class Casting
    {

        public static void ImplicitCasting() 
        {
            int num = 100;
            double result = num; // Implicit casting from int to double
            Console.WriteLine(result); // Output: 100

            char name = 'a';
            int value = name;
            Console.WriteLine(result);
        }

        public static void ExplicitCasting()
        {
            double d = 99.99;
            int i = (int)d; // Explicit casting from double to int
            Console.WriteLine(i); // Output: 99 (decimal part lost)

        }
    }
}
