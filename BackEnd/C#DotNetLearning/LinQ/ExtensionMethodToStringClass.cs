using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DotNetLearning.LinQ
{
    public static class ExtensionMethodToStringClass
    {
        public static (int wordCount, int charCount) GetWordCount(this string str)
        {
            if(!String.IsNullOrEmpty(str))
            {

                int wordCount = str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
                int charCount = str.Count(c => c != ' ');
                return (wordCount, charCount);
            }
            return (0,0);
        }

        public static int GetNumberCount(this int num)
        {
            if(num != 0)
                return num.ToString().Length;
            return 0;
        }
    }

}

