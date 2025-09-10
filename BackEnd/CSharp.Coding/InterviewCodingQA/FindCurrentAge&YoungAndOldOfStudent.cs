namespace CSharp.RealWorld.InterviewCodingQA
{
    public class FindCurrentAgeOfStudent
    {
        public static int CurrentAgeOfStudent(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;

            DateTime dateTime = DateTime.UtcNow;

            int age = today.Year - dateOfBirth.Year;


            int a = 6;
            Console.WriteLine(a++ + ++a);


            if(dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public static Dictionary<string, int> YoungestStudent(Dictionary<string, DateTime> students)
        {

            Dictionary<string, int> studentAges = new Dictionary<string, int>();

            DateTime today = DateTime.Now;

            foreach(var item in students)
            {
                string DOB = item.Value.ToString();
                DateTime dateOfBirth = DateTime.Parse(DOB);

                int age = today.Year - dateOfBirth.Year;

                studentAges[item.Key] = age;
            }

            string? youngestName = "";
            int? youngestAge = int.MaxValue;

            string? oldestName = "";
            int? oldestAge = int.MinValue;

            foreach(var item in studentAges)
            {
                if(item.Value < youngestAge)
                {
                    youngestAge = item.Value;
                    youngestName = item.Key;
                }

                if(item.Value > oldestAge)
                {
                    oldestAge = item.Value;
                    oldestName = item.Key;
                }


            }
            Console.WriteLine($"Youngest: {youngestName} ({youngestAge} years old)");
            Console.WriteLine($"Oldest: {oldestName} ({oldestAge} years old)");

            return studentAges;

        }

    }
}
