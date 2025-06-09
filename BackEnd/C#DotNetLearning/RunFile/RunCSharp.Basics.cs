using C_Basics_Fundamentals;
using C_Basics_Fundamentals.ControlFlowStatements;
using C_Basics_Fundamentals.ExceptionHandling;
using C_Basics_Fundamentals.Methods;
using C_Basics_Fundamentals.Operators;
using C_Basics_Fundamentals.Variables;
using CSharp.Coding.DifLogicalProgram;
using CSharp.Coding.Swapping;
using CSharp.Intermediate.LinQ;
using CSharpLearning.Loops;
using CSharpLearning.Modifiers;
using CSharpLearning.ParameterPassingMechanisms;
using static CSharp.Basics.AccessModifiers.AccessModifiers;

namespace CSharpLearning.RunFile
{
    public static class RunCSharpBasics
    {

        //Access Modifier
        public static void RunAccessModifiers()
        {
            BaseClass baseClass = new BaseClass();

            DerivedClass derivedClass = new DerivedClass();

            OtherClass otherClass = new OtherClass();

            baseClass.BaseClassEx();
            Console.WriteLine(" ");
            derivedClass.DerivedClassEx();
            Console.WriteLine(" ");
            otherClass.OtherClassEx();

        }

        //Basic OOPs
        public static void RunBasicOOP()
        {
            ForLoop.ExecForLoop();
        }

        //ControlFlowStatements
        public static void RunControlFlowStatements()
        {
            ControlFlowStatements.ControlFlowStatementsEx();
            ForLoop.ExecForLoop();
        }

        //ExceptionHandling
        public static void RunExceptionHandling()
        {
            ExceptionHandling.ExceptionHandlingEx();
        }

        //LogicalProgram
        public static void RunLogicalProgram()
        {
            SwapTwoValues.SwapTwoNumber();
            SwapTwoValues.SwapTwoStrings();
            RemoveDuplicate.RemoveDupFromArray();
            DuckNumOrNot.DuckNumberOrNot();
        }

        //Methods
        public static void RunMethods()
        {
            Console.WriteLine(Methods.Add(5, 3));
            Console.WriteLine(Methods.Add(2.5, 3.5));
            Console.WriteLine(Methods.Subtract(15, 30));
            Console.WriteLine(Methods.Subtract(21.5, 32.5));
        }

        //Operators
        public static void RunOperators()
        {
            Operators.OperatorsEx();
        }


        //ParameterPassingMechanisms
        public static void RunParameterPassingMechanisms()
        {

            //Pass By Value
            int value0 = 2;
            PassByValue.Default(value0);
            Console.WriteLine(value0);

            //Pass By Reference
            int value1 = 2;
            PassByReference.Ref(ref value1);
            Console.WriteLine(value1);

            int value2 = 5;
            PassByReference.Out(out value2);
            Console.WriteLine(value2);

        }

        //VariablesAndDataTypes
        public static void RunVariablesAndDataTypes()
        {
            // Call static method to demonstrate local variables
            VariablesAndDataTypes.VariablesAndDataType();

            Console.WriteLine("\n---- Instance & Static Members ----");

            // Create object (instance) of VariablesAndDataTypes
            VariablesAndDataTypes variablesAndDataTypes = new VariablesAndDataTypes();

            // Call instance method with parameter variable
            variablesAndDataTypes.PrintMessage("Hello again!");

            // Set property value
            variablesAndDataTypes.Age = 28;

            // Access instance variable, property, readonly field
            Console.WriteLine($"Instance Name: {variablesAndDataTypes.instanceName}");
            Console.WriteLine($"Created At (Readonly Field): {variablesAndDataTypes.createdAt}");
            Console.WriteLine($"Auto Property Age: {variablesAndDataTypes.Age}");

            // Access static variable, constant, static readonly
            Console.WriteLine($"Static Counter: {VariablesAndDataTypes.staticCounter}");
            Console.WriteLine($"Const Field Gravity: {VariablesAndDataTypes.Gravity}");
            Console.WriteLine($"Static Readonly AppVersion: {VariablesAndDataTypes.appVersion}");

            //StaticConstReadonly staticConstReadonly = new StaticConstReadonly();

        }












    }
}
