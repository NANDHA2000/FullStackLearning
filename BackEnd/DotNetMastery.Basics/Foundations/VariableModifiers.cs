using System;

namespace DotNetMastery.Basics.Foundations
{
    /* -----------------------------------------------------------------------------
    Variable Modifiers Reference: const vs readonly vs static
    -----------------------------------------------------------------------------
    📌 1. const -> Compile-time constant
          - Value must be assigned at declaration. Cannot be changed later.
          - Implicitly static (belongs to the class, not the instance).
          - Value is baked directly into the IL code at compile time.

    📌 2. readonly -> Runtime constant
          - Value can be assigned at declaration OR inside a constructor.
          - Can have a different value for each object instance if set via constructor.
          - Value is resolved at runtime (can depend on runtime calculations).

    📌 3. static -> Shared type member
          - Belongs to the class itself, not to any specific object instance.
          - Only one copy exists in memory for the entire application lifecycle.
          - Value can be modified at runtime (unless combined with readonly).
    -----------------------------------------------------------------------------
    */

    public class VariableModifiers
    {
        #region Structural Fields

        // Compile-time literal constant
        public const int CompileTimeConstant = 10;

        // Runtime object-level constant
        public readonly int RuntimeConstant = 20;

        // Shared class-level memory space variable
        public static int SharedVariable = 30;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor demonstrating dynamic runtime initialization allocations.
        /// </summary>
        public VariableModifiers(int customValue)
        {
            // ✅ Legal: readonly variables can be assigned/modified inside constructors
            RuntimeConstant = customValue;

            // ✅ Legal: static fields are accessible and mutable across lifecycle methods
            SharedVariable = CompileTimeConstant + RuntimeConstant;
        }

        #endregion
    }
}