using DotNetMastery.Basics.ControlFlowStatements;
using DotNetMastery.Basics.ExceptionHandling;
using DotNetMastery.Basics.Foundations;
using DotNetMastery.Basics.Methods;
using DotNetMastery.Basics.TypeConversion;

namespace DotNetMastery.RunFile
{
    public static class RunCSharpBasics
    {
        #region Self-Explanatory UI Layout Helpers

        private static void PrintSectionHeader(string number, string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n==================== [ SECTION {number}: {title.ToUpper()} ] ====================");
            Console.ResetColor();
        }

        private static void PrintConceptLabel(string descriptiveGoal)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n  >> TESTING: {descriptiveGoal}");
            Console.ResetColor();
        }

        private static void PrintResultRow(string label, string result)
        {
            Console.WriteLine($"     {label,-30} : {result}");
        }

        #endregion

        /*// 1. Access Modifiers
        public static void RunAccessModifiers()
        {
            PrintSectionHeader("1", "Access Modifiers & Member Visibility Rules");

            PrintConceptLabel("Internal Access Scope (Visibility from within the exact same Class)");
            new BaseClass().DemonstrateBaseClassAccess();

            PrintConceptLabel("Inherited Access Scope (Visibility from a Derived Subclass)");
            new DerivedClass().DemonstrateDerivedClassAccess();

            PrintConceptLabel("External Access Scope (Visibility from an unrelated, Non-Derived Class)");
            new OtherClass().DemonstrateOtherClassAccess();
        }*/

        // 1. Control Flow Statements & Loops
        public static void RunControlFlowStatements()
        {
            PrintSectionHeader("1", "Control Flow Branching & Iteration Engines");

            PrintConceptLabel("Conditional Branching Evaluation using If-Else Ladder");
            ControlFlowStatements.DemonstrateIfElse(7);

            PrintConceptLabel("Multi-way Branching Selection using Switch Pattern Matching");
            ControlFlowStatements.DemonstrateSwitch(3);

            PrintConceptLabel("Definite Counter Loops (For Loop handling Break & Continue jumps)");
            ControlFlowStatements.DemonstrateForLoop();

            PrintConceptLabel("Entry-Controlled Condition Loops (While Loop structure)");
            ControlFlowStatements.DemonstrateWhileLoop();

            PrintConceptLabel("Exit-Controlled Condition Loops (Do-While guaranteed execution pass)");
            ControlFlowStatements.DemonstrateDoWhileLoop();

            PrintConceptLabel("Type-Safe Collection Sequential Traversal (Foreach Array Stream)");
            Console.Write("     Streamed Output           : ");
            ControlFlowStatements.DemonstrateForEachLoop(new int[] { 10, 20, 30 });
            Console.WriteLine();

            // Advanced Loops Catalog Deep Dive
            PrintConceptLabel("Comprehensive Loops & Index Math Playground");
            LoopsWorkFlow.DemonstrateStandardIncrementLoop();
            LoopsWorkFlow.DemonstrateReverseDecrementLoop();
            LoopsWorkFlow.DemonstrateSteppingLoop();
            LoopsWorkFlow.DemonstrateArrayForLoop();
            LoopsWorkFlow.DemonstrateNestedLoop();
            LoopsWorkFlow.DemonstrateStandardWhileLoop();
            LoopsWorkFlow.DemonstrateStandardDoWhileLoop();
            LoopsWorkFlow.DemonstrateForEachCollectionLoop();
            LoopsWorkFlow.DemonstrateLoopWithContinue();
            LoopsWorkFlow.DemonstrateInfiniteLoopWithBreak();
        }

        // 2. Exception Handling
        public static void RunExceptionHandling()
        {
            PrintSectionHeader("2", "Structured Error Catching Layout (Try-Catch-Finally)");

            PrintConceptLabel("Successful Code Execution Execution Pathway (No errors triggered)");
            ExceptionHandling.DemonstrateDivision(10, 2);

            PrintConceptLabel("Anomaly Interception Flow (Handling runtime DivideByZeroException)");
            ExceptionHandling.DemonstrateDivision(10, 0);
        }

        // 3. Foundations
        public static void RunFountations()
        {
            /*-------------------------------------------------------------------------------------------------------*/

            PrintSectionHeader("3", "Expressions & Evaluation Matrices");
            PrintConceptLabel("Core C# Arithmetic, Relational, Logical, and Assignment Evaluations");

            Operators.DemonstrateArithmetic(10, 3);
            Operators.DemonstrateRelational(10, 3);
            Operators.DemonstrateLogical(true, false);
            Operators.DemonstrateBitwise(10, 3);
            Operators.DemonstrateAssignment(10);

            PrintResultRow("Integer Division Truncation (10 / 3)", (10 / 3).ToString());
            PrintResultRow("Modulo Remainder Logic (10 % 3)", (10 % 3).ToString());
            PrintResultRow("Boolean Comparative Check (10 > 3)", (10 > 3).ToString());
            PrintResultRow("Short-Circuit Logic Gates (True && False)", (true && false).ToString());
            PrintResultRow("Inline Ternary Condition Assignment", Operators.EvaluateMaxViaTernary(10, 3).ToString());


            /*-------------------------------------------------------------------------------------------------------*/

            PrintSectionHeader("4", "Variable Scopes, Structural Layouts & Allocation Lifecycles");

            PrintConceptLabel("Localized Execution Frame Lifecycles (Method Scope Stack Allocations)");
            VariablesAndDataTypes.DemonstrateLocalVariables();
            PrintResultRow("Stack Status", "Temporary execution memory cleared seamlessly.");

            PrintConceptLabel("Dynamic Object Instance Allocations (Class Scope Managed Heap Layout)");
            VariablesAndDataTypes demo = new VariablesAndDataTypes();
            demo.Age = 28;
            PrintResultRow("Default Instance Field Data", demo.instanceName);
            PrintResultRow("Runtime Readonly Constructor Timestamp", demo.createdAt.ToString("yyyy-MM-dd HH:mm:ss"));
            PrintResultRow("Mutated Public Auto-Property Value", demo.Age.ToString());

            PrintConceptLabel("Global Shared Type Allocations (Permanent High-Frequency Application Memory)");
            PrintResultRow("Global Static Counter Tracker", VariablesAndDataTypes.staticCounter.ToString());
            PrintResultRow("Baked Compile-Time Literal Constant", VariablesAndDataTypes.Gravity.ToString());
            PrintResultRow("Runtime Evaluated Static Readonly Version", VariablesAndDataTypes.AppVersion);

            /*-------------------------------------------------------------------------------------------------------*/
        }
        // 4. Methods 
        public static void RunMethods()
        {
            /*-------------------------------------------------------------------------------------------------------*/

            PrintSectionHeader("5", "Method Signatures & Compile-Time Polymorphism");
            PrintConceptLabel("Automatic Overload Resolution via incoming Parameter Types");

            PrintResultRow("Integer Addition Signatures", Methods.Add(5, 3).ToString());
            PrintResultRow("Double Addition Signatures", Methods.Add(2.5, 3.5).ToString());
            PrintResultRow("Integer Subtraction Signatures", Methods.Subtract(15, 30).ToString());
            PrintResultRow("Double Subtraction Signatures", Methods.Subtract(21.5, 32.5).ToString());


            /*-------------------------------------------------------------------------------------------------------*/


            PrintSectionHeader("6", "Memory Configurations & Stack Parameter Scope");

            PrintConceptLabel("Default Behavior: Pass-by-Value (Isolated Method Stack Frame Copy)");
            int val0 = 2;
            PrintResultRow("Caller Stack Value Before Call", val0.ToString());
            PassByValue.DemonstratePassByValue(val0);
            PrintResultRow("Caller Stack Value Post Return", val0.ToString() + " (Unchanged safe state)");

            PrintConceptLabel("Explicit Modifier: Pass-by-Reference using 'ref' (Direct Memory Address Pointer)");
            int val1 = 2;
            PrintResultRow("Caller Stack Value Before Call", val1.ToString());
            ParameterPassing.DemonstrateRef(ref val1);
            PrintResultRow("Caller Stack Value Post Return", val1.ToString() + " (Mutated directly via pointer)");

            PrintConceptLabel("Explicit Modifier: Pass-by-Reference using 'out' (Mandatory Internal Initialization)");
            int val2;
            ParameterPassing.DemonstrateOut(out val2);
            PrintResultRow("Caller Stack Value Post Return", val2.ToString() + " (Populated by method body)");

            PrintConceptLabel("Explicit Modifier: Pass-by-Reference using 'in' (Performance Optimized Read-Only Pointer)");
            int val3 = 100;
            ParameterPassing.DemonstrateIn(in val3);
            PrintResultRow("Caller Stack Value Post Return", val3.ToString() + " (Protected structural address reference)");

            /*-------------------------------------------------------------------------------------------------------*/


        }

        // 6. Boxing And Unboxing
        public static void RunTypeConversion()
        {
            /*-------------------------------------------------------------------------------------------------------*/

            PrintSectionHeader("7", "Memory Layout Transformations (Boxing vs Unboxing Overhead)");
            PrintConceptLabel("Extracting Value Types (Stack) to Reference Wrappers (Heap Object Instances)");

            BoxingAndUnboxing.DemonstrateConversion();
            PrintResultRow("Memory Processing Status", "Stack-to-heap box transition ran silently in background memory layers.");

            /*-------------------------------------------------------------------------------------------------------*/

            PrintSectionHeader("8", "Data Width Conversion Hierarchies (Widening vs Narrowing Truncation)");
            PrintConceptLabel("Evaluating Safe Implicit Assignments vs Data-Loss Bound Explicit Casts");

            TypeCasting.ImplicitConversion();
            TypeCasting.ExplicitConversion();
            PrintResultRow("Casting Pipeline Status", "Implicit memory widening and explicit size narrowing conversions verified.");

            /*-------------------------------------------------------------------------------------------------------*/
        }

    }
}