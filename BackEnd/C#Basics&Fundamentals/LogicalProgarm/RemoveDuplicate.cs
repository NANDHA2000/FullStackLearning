using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.LogicalProgarm
{
    public class RemoveDuplicate
    {
        public static void RemoveDupFromArray() 
        {

            int[] arr = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };

            HashSet<int> hashSet = arr.ToHashSet();

            foreach(var item in hashSet)
            {
                /*                Console.Write("{ ");
                                Console.Write(string.Join(", ", hashSet.OrderBy(x => x)));
                                Console.WriteLine(" }");*/

                Console.WriteLine(item);
            }



            #region Nested For Loop Approach

            int i = 0, j = 0;
            int[] intarr = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };

            for(i = 0; i < intarr.Length; i++)
            {
                for(j = 0; j < intarr.Length; j++)
                {
                    if(i == j)
                        continue;
                    if(intarr[j] == intarr[i])
                        break;
                }
                if(intarr.Length == j)
                {
                    Console.Write(intarr[i] + " ");
                }
            }

            #endregion
        }
    }
}
