using System;

namespace DotNetMastery.Basics.TypeConversion
{
    /* -----------------------------------------------------------------------------
    C# Type Casting Reference Cheat Sheet
    -----------------------------------------------------------------------------
    Type casting is the process of converting a variable from one data type to another.

    | Casting Type     | Direction            | Requires Cast | Risk of Data Loss | Example        |
    | ---------------- | -------------------- | ------------- | ----------------- | -------------- |
    | Implicit Casting | Small → Large type   | ❌ No          | ❌ No              | `int → double` |
    | Explicit Casting | Large → Small type   | ✅ Yes         | ✅ Yes             | `double → int` |
    | Upcasting        | Derived → Base class | ❌ No          | ❌ No              | `Dog → Animal` |
    | Downcasting      | Base → Derived class | ✅ Yes         | ✅ Yes (if wrong)  | `Animal → Dog` |

    🔄 Implicit Data Type Hierarchy Flow:
    char -> int -> long -> float -> double
    -----------------------------------------------------------------------------
    */

    public static class TypeCasting
    {
        #region 1. Implicit Casting (Automatic)

        /// <summary>
        /// Demonstrates safe, automatic conversion performed by the compiler.
        /// occurs when converting a smaller numeric type to a larger numeric type.
        /// </summary>
        public static void ImplicitConversion()
        {
            int num = 100;

            // Implicit conversion: int fits perfectly into a double container without data loss
            double result = num;

            char characterNode = 'a';

            // Implicit conversion: char maps directly to its underlying ASCII/Unicode integer value
            int asciiValue = characterNode;
        }

        #endregion

        #region 2. Explicit Casting (Manual)

        /// <summary>
        /// Demonstrates manual conversion using a cast operator syntax: (targetType)variable.
        /// Required when converting larger types to smaller types or when data truncation may occur.
        /// </summary>
        public static void ExplicitConversion()
        {
            double floatingValue = 99.99;

            // Explicit conversion: Truncates everything past the decimal point
            int truncatedInteger = (int)floatingValue;
        }

        #endregion
    }
}