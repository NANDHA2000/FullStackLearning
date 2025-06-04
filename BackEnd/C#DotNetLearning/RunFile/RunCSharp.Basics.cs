using C_DotNetLearning.LogicalProgarm;
using C_DotNetLearning.Modifiers;
using C_DotNetLearning.ParameterPassingMechanisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_DotNetLearning.AccessModifiers.AccessModifiers;

namespace C_DotNetLearning.RunFile
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


        public static void RunLogicalProgram()
        {
            SwapTwoValues.SwapTwoNumber();
            SwapTwoValues.SwapTwoStrings();
        }
    }
}
