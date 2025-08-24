using CSharp.RealWorld.InterviewCodingQA;

namespace CSharpLearning.RunFile
{
    public class RunCSharpRealWorld
    {
        public static void RunFindCurrentAgeOfStudent()
        {
            string studentName = "John Doe";
            DateTime dob = new DateTime(2000, 12, 15);

            int age = FindCurrentAgeOfStudent.CurrentAgeOfStudent(dob);

            Console.WriteLine($"Current age of student {studentName} is {age} years.");
        }


        public static void RunFindOldestAndYoungestAgeOfStudent()
        {
            Dictionary<string, DateTime> students = new Dictionary<string, DateTime>()
            {
                { "John Doe", new DateTime(2000,12,15) },
                { "Jane Smith",new DateTime(2002,05,20) },
                { "Alice Johnson",new DateTime(1999,11,30)}
            };

            string studentName = "John Doe";
            DateTime dob = new DateTime(2000, 12, 15);

            //int age = FindCurrentAgeOfStudent.YoungestStudent(students);

            //Console.WriteLine($"Current age of student {studentName} is {age} years.");
        }
    }
}
