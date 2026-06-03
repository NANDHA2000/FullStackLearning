using System;

namespace DotNetMastery.Basics.Foundations
{
    /* -----------------------------------------------------------------------------
    C# Variable Types & Scope Reference
    -----------------------------------------------------------------------------
    📌 Local Variable     -> Declared inside a method. Exists only during execution of that method.
    📌 Instance Field    -> Declared in a class without 'static'. Each object gets its own copy.
    📌 Static Field      -> Declared with 'static'. Shared globally across all object instances.
    📌 Constant Field    -> Value known at compile-time, unchangeable, implicitly static.
    📌 Readonly Field    -> Runtime constant assigned at declaration or inside the constructor.
    📌 Static Readonly   -> Shared across all instances, assigned at declaration or static constructor.
    📌 Auto-Property     -> Simplifies field declaration by letting the compiler generate backing fields.
    📌 Parameter         -> Declared in a method signature to receive incoming data from caller.
    📌 var Keyword       -> Implicitly typed variable; type is inferred by compiler at compile-time.
    📌 dynamic Keyword   -> Type checked and resolved entirely at runtime; can change types dynamically.
    -----------------------------------------------------------------------------
    */

    public class VariablesAndDataTypes
    {
        #region Class Fields & Properties

        // Instance variable (Each allocated object maintains an isolated copy)
        public string instanceName = "Default Instance Value";

        // Static variable (Global application state slot shared across all instances)
        public static int staticCounter = 0;

        // Constant field (Fixed structural compilation literal)
        public const double Gravity = 9.8;

        // Readonly field (Immutable state locked post-construction sequence execution)
        public readonly DateTime createdAt;

        // Static readonly field (Shared application constant populated at initialization runtime execution)
        public static readonly string AppVersion = "1.0." + DateTime.Now.Minute;

        // Auto-property (Implicitly backed field managed natively by compiler optimization layers)
        public int Age { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes instance parameters and tracks class allocations.
        /// </summary>
        public VariablesAndDataTypes()
        {
            // Lock current timestamp initialization into the runtime reference container
            createdAt = DateTime.Now;

            // Increment structural global tracker whenever a new memory instance initializes
            staticCounter++;
        }

        #endregion

        #region Local Variable Demonstrations

        /// <summary>
        /// Showcases localized execution frame stack tracking scopes.
        /// </summary>
        public static void DemonstrateLocalVariables()
        {
            // Strongly typed local variables
            int localAge = 30;
            float localHeight = 5.9f;
            double localPi = 3.14159;
            char localGrade = 'A';
            bool localIsActive = true;
            string localName = "John Doe";

            // var keyword: Implicitly strongly-typed by the compiler at compile-time
            var localCity = "Bangalore";

            // dynamic keyword: Resolution occurs entirely at runtime; values can safely mutate underlying types
            dynamic localSalary = 50000;
            localSalary = "Fifty Thousand"; // Safe conversion

            // Local context constant allocation
            const double localGravity = 9.8;
        }

        #endregion

        #region Instance Methods

        /// <summary>
        /// Example method showcasing incoming signature input arguments parameters tracking scopes.
        /// </summary>
        public void PrintMessage(string message)
        {
            // 'message' variable only lives within this stack frame invocation window context
            Console.WriteLine(message);
        }

        #endregion
    }
}