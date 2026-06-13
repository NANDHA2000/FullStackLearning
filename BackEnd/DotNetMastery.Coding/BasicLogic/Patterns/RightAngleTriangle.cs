namespace DotNetMastery.Coding.BasicLogic.Patterns
{
    public class RightAngleTrianglePattern
    {
        public static void RightAngleTriangle()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
