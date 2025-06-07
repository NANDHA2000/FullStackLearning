using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewPreparation.Coding.Reversing.Reversing
{
    public class ReverseTheOrderOfWord
    {

        public void ReverseTheOrderOfWords()
        {
            string Input = "I'm Super hero";

            string[] Words = Input.Split(' ');

            for(int i = Words.Length - 1; i >= 0; i--)
            {
                Console.Write(Words[i]);

                if(i > 0)
                {
                    Console.Write(" ");
                }
            }


            // Output : hero Super I'm
        }
    }
}
