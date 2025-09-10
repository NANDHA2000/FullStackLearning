/*
 
IComparable<T> → defines default sorting for a class.

IComparer<T> → custom sorting logic.

*/



using CSharp.CommonUtils.Models;

namespace CSharp.Intermediate.Interfaces
{
    public class IComparableAndIComparer
    {

        public class NameComparer : IComparer<Student>
        {
            public int Compare(Student x, Student y) => x.Name!.CompareTo(y.Name);
        }

        public static void IComparableDemo()
        {
            var students = new List<Student>
            {
                new Student { Name = "Bob", Marks = 70 },
                new Student { Name = "Alice", Marks = 90 }
            };

            students.Sort(); // Uses IComparable (Marks)
            Console.WriteLine("Sorted by Marks:");
            students.ForEach(s => Console.WriteLine(s.Name));

            students.Sort(new NameComparer()); // Uses IComparer (Name)
            Console.WriteLine("Sorted by Name:");
            students.ForEach(s => Console.WriteLine(s.Name));
        }
    }
}
