using System;

namespace DotNetMastery.Basics.Foundations
{
    /* -----------------------------------------------------------------------------
    C# Operators Cheat Sheet
    -----------------------------------------------------------------------------
    📌 Arithmetic  -> Performs standard math (+, -, *, /, %). Note: integer division truncates.
    📌 Relational  -> Compares two values and returns a boolean value (==, !=, >, <, >=, <=).
    📌 Logical     -> Evaluates boolean conditions with short-circuiting logic (&&, ||, !).
    📌 Bitwise     -> Operates on binary representations of integers at bit-level (&, |, ^, ~, <<, >>).
    📌 Assignment  -> Assigns and updates values efficiently (=, +=, -=, *=, /=, %=).
    📌 Ternary     -> Inline conditional assignment acting as a shorthand for if-else structures.
    -----------------------------------------------------------------------------
    */

    public static class Operators
    {
        #region 1. Arithmetic Operators

        /// <summary>
        /// Demonstrates standard mathematical operators.
        /// </summary>
        public static void DemonstrateArithmetic(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;  // Integer division truncates decimal components
            int remainder = a % b; // Modulo operation
        }

        #endregion

        #region 2. Relational Operators

        /// <summary>
        /// Demonstrates valuation comparison operators resulting in boolean returns.
        /// </summary>
        public static void DemonstrateRelational(int a, int b)
        {
            bool isGreater = a > b;
            bool isEqual = a == b;
            bool isNotEqual = a != b;
        }

        #endregion

        #region 3. Logical Operators

        /// <summary>
        /// Demonstrates conditional evaluation workflows using short-circuiting logic.
        /// </summary>
        public static void DemonstrateLogical(bool x, bool y)
        {
            bool andResult = x && y; // True only if both operands evaluate to true
            bool orResult = x || y;  // True if at least one operand evaluates to true
            bool notResult = !x;     // Inverts the current boolean status
        }

        #endregion

        #region 4. Bitwise Operators

        /// <summary>
        /// Demonstrates bit-level operations performed on underlying binary representations.
        /// </summary>
        public static void DemonstrateBitwise(int a, int b)
        {
            int bitwiseAnd = a & b;
            int bitwiseOr = a | b;
            int bitwiseXor = a ^ b;
        }

        #endregion

        #region 5. Assignment Operators

        /// <summary>
        /// Demonstrates self-updating inline valuation assignments.
        /// </summary>
        public static void DemonstrateAssignment(int a)
        {
            a += 5; // Equivalent to: a = a + 5;
            a *= 2; // Equivalent to: a = a * 2;
        }

        #endregion

        #region 6. Ternary Operator

        /// <summary>
        /// Demonstrates shorthand inline assignment logic based on condition states.
        /// </summary>
        public static int EvaluateMaxViaTernary(int a, int b)
        {
            // Syntax: condition ? value_if_true : value_if_false;
            return (a > b) ? a : b;
        }

        #endregion
    }
}