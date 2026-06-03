using System;

namespace DotNetMastery.Basics.TypeConversion
{
    /* -----------------------------------------------------------------------------
    C# Boxing and Unboxing Reference
    -----------------------------------------------------------------------------
    | Feature          | Boxing                                         | Unboxing                          |
    | ---------------- | ---------------------------------------------- | --------------------------------- |
    | Meaning          | Converts value type → object type              | Converts object type → value type |
    | Happens when     | Assigning value type to `object` or `interface`| Casting object back to value type |
    | Cost             | Performance overhead (heap allocation)         | Possible `InvalidCastException`   |
    | Automatic/Manual | Automatic                                      | Explicit cast required            |
    -----------------------------------------------------------------------------
    */

    public static class BoxingAndUnboxing
    {
        #region Boxing & Unboxing Core Logic

        /// <summary>
        /// Demonstrates the mechanical memory transition between value types (stack) and reference types (heap).
        /// </summary>
        public static void DemonstrateConversion()
        {
            // ======= BOXING (Stack to Heap) =======
            // Initializing a standard value type on the execution stack
            int num = 100;

            // Boxing occurs automatically when a value type is assigned to an object type.
            // The runtime wraps the value inside an object instance allocated on the managed heap.
            object obj = num;

            // ======= UNBOXING (Heap to Stack) =======
            // Unboxing extracts the original value directly from the heap wrapper instance.
            // This operation requires an explicit cast and is strictly runtime type-checked.
            int unboxedNum = (int)obj;

            // Modifying the unboxed stack variable has zero impact on the separate boxed heap data container
            unboxedNum = 200;
        }

        #endregion
    }
}