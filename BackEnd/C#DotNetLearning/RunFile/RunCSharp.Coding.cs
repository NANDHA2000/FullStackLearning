using CSharp.Coding.Duplicate;
using CSharp.Coding.Reversing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.RunFile
{
    public class RunCSharpCoding
    {

        //LogicalProgram
        public static void RunLogicalProgram()
        {
            ReversingString.ReversingInput();
            ReversingNumber.ReversingNumbers();
            Reversing.ReverseTheOrderOfWords();


            DuplicateFromString.DuplicateFromStringEx();
        }
    }
}
