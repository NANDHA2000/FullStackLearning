namespace DotNetMastery.Basics.Methods
{
    /* -----------------------------------------------------------------------------
    C# Parameter Passing Mechanisms Reference
    -----------------------------------------------------------------------------
    🔁 ref (Reference Parameter - Read/Write)
       - Passes a reference to the caller's variable.
       - Variable MUST be initialized before passing it.
       - The method can both read and modify the original variable.

    🆙 out (Output Parameter - Write-Only Initial)
       - Passes a reference to the caller's variable.
       - Variable does NOT need to be initialized before passing.
       - The method MUST assign a value to it before returning.

    🔒 in (Read-Only Reference)
       - Passes a reference to the caller's variable to optimize performance (no copying).
       - Variable MUST be initialized before passing.
       - The method CANNOT modify the variable (it is strictly read-only).
    -----------------------------------------------------------------------------
    */

    public static class ParameterPassing
    {
        #region Core Mechanisms Implementations

        /// <summary>
        /// Reads and modifies the external variable directly (Read/Write Reference).
        /// </summary>
        public static void DemonstrateRef(ref int x)
        {
            x = x + 10; // Modifies the actual storage location of the caller
        }

        /// <summary>
        /// Enforces assignment to the target container before exiting (Write-Only Initial Reference).
        /// </summary>
        public static void DemonstrateOut(out int x)
        {
            x = 0; // Mandatory initialization before any reading operations or method exit
            x = x + 10;
        }

        /// <summary>
        /// Passes by reference for performance but enforces read-only safety (Read-Only Reference).
        /// </summary>
        public static void DemonstrateIn(in int x)
        {
            // x = x + 10; // ❌ Compile Error! Variables passed with 'in' are read-only.

            int calculationValue = x + 10; // Safe to read and evaluate inside local memory
        }

        #endregion
    }
}