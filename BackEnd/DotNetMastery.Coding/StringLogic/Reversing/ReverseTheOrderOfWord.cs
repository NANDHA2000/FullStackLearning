namespace DotNetMastery.Coding.StringLogic.Reversing
{
    public static class Reversing
    {
        public static void ReverseTheOrderOfWords()
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
