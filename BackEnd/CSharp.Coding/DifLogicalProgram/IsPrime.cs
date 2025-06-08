namespace CSharp.Coding.DifLogicalProgram
{
    public class IsPrime
    {
        public void IsPrimeOrNot(int num)
        {
            if(num <= 1)
                Console.WriteLine("Number should be above the value of 1");

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                    Console.WriteLine("Number is not prime");
                else
                    Console.WriteLine("Number is prime!!");
            }
            
        }

        public void IsPrimeOrNot() 
        {

            int number = 6;
            bool isPrime = true;

            for(int i = 2; i * i <= number; i++) // Two iteration if we use 1 "i"
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    break; // Exit early if a divisor is found
                }
            }

            if(isPrime && number > 1)
                Console.WriteLine("Number is prime!!");
            else
                Console.WriteLine("Number is not a prime!!");
        }
    }
}
