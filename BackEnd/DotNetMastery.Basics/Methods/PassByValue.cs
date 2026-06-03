using System;

namespace DotNetMastery.Basics.Methods
{
    /* -----------------------------------------------------------------------------
    C# Parameter Passing Mechanisms: Pass By Value (Default Behavior)
    -----------------------------------------------------------------------------
    📦 Pass By Value
       - This is the default mechanism in C# when passing parameters without modifiers.
       - A complete duplicate copy of the variable's value is created on the stack.
       - The called method operates entirely within its own stack frame on this isolated copy.
       - Any mutations or modifications made inside the method have ZERO effect on the 
         caller's original variable container.
    -----------------------------------------------------------------------------
    */

    public static class PassByValue
    {
        /// <summary>
        /// Receives a completely independent copy of the passed integer.
        /// Modifying this local variable does not affect the caller's original variable.
        /// </summary>
        public static void DemonstratePassByValue(int x)
        {
            x = x + 10; // Modifies ONLY the local stack copy inside this method frame
        }
    }
}