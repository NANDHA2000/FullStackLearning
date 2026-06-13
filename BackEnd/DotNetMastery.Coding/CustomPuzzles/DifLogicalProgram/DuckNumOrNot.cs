namespace DotNetMastery.Coding.CustomPuzzles.DifLogicalProgram
{
    public class DuckNumOrNot
    {
        public static void DuckNumberOrNot() 
        {
            string number = "12304";
            if(string.IsNullOrEmpty(number) || number[0] == '0') 
            {
                Console.WriteLine("Number is not a Duck Number");
                return;
            }

            // Check if there's a '0' anywhere after the first digit
            for(int i = 1; i < number.Length; i++)
            {
                if(number[i] == '0')
                {
                    Console.WriteLine("Number is Duck Number");
                    return;
                }
            }

            Console.WriteLine("Number is not a Duck Number");
        }
    }
}
