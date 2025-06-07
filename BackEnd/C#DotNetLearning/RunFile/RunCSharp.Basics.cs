using C_Basics_Fundamentals;
using C_Basics_Fundamentals.ControlFlowStatements;
using C_Basics_Fundamentals.ExceptionHandling;
using C_Basics_Fundamentals.Methods;
using C_Basics_Fundamentals.Operators;
using CSharp.Intermediate.LinQ;
using CSharpLearning.LogicalProgarm;
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
            var baseObj = new BaseClass();
            var derivedObj = new DerivedClass();
            var otherObj = new OtherClass();

            baseObj.ShowAccessInBase();
            Console.WriteLine("----------------------");

            derivedObj.ShowAccessInDerived();
            Console.WriteLine("----------------------");

            otherObj.ShowAccessInOther();
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
            VariablesAndDataTypes.VariablesAndDataType();
        }












    }
}
