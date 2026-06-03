using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMastery.Intermediate.ExtensionMethod
{
    public static class ExtensionMethod
    {

        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }
    }
}
