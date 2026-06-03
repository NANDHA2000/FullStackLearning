using System;

namespace DotNetMastery.Basics.Methods
{
    /* -----------------------------------------------------------------------------
    C# Methods & Method Overloading Reference
    -----------------------------------------------------------------------------
    🧩 Method Overloading (Compile-Time Polymorphism)
       - Allows a class to have multiple methods with the exact same name.
       - MUST have different signatures (different parameter types, numbers, or order).
       - The return type alone is NOT enough to overload a method.
    -----------------------------------------------------------------------------
    */

    public static class Methods
    {
        #region Overloaded Add Methods

        /// <summary>
        /// Overload 1: Adds two integers.
        /// </summary>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Overload 2: Adds two double-precision floating-point numbers.
        /// </summary>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        #endregion

        #region Overloaded Subtract Methods

        /// <summary>
        /// Overload 1: Subtracts two integers.
        /// </summary>
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Overload 2: Subtracts two double-precision floating-point numbers.
        /// </summary>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        #endregion
    }
}