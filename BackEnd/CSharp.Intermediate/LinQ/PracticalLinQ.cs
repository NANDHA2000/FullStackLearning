using CSharp.CommonUtils.Database.LinQ;
using CSharp.CommonUtils.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Intermediate.LinQ
{
    public class PracticalLinQ
    {
        public static void Practical1() 
        {
            // INTERVIEW QUESTION 

            var person = PersonDatabase.GetPersonDatabase();

            string search = "hi";
            var result = person
                .Where(p => p.Name != null && p.Name.ToLower().Contains(search.ToLower()))
                .Select(p => new { p.ID, p.Name, p.Phone })
                .ToList();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }

        public static void Practical2() 
        {

            List<Person> people = new List<Person>
            {
                new Person { ID = 1, Name = "Nandha", Phone = "098769993" },
                new Person { ID = 2, Name = "Kumar", Phone = "098761234" },
                new Person { ID = 3, Name = "Subash", Phone = "098769993" },
                new Person { ID = 4, Name = "Ajay", Phone = "098761234" }
            };


            var value = people.Select(p => new { NameoftheStudents = p.Name, PhoneNumbers = p.Phone });
            // bool value = people.Any(p=>p.Name =="Nandha");

            //var value = people.Select(p => new { p.ID,p.Name,p.Phone }).OrderBy(p => p.Name).GroupBy(p => p.Phone).ToList();
            //var value = people.GroupBy(p => new { p.ID, p.Name, p.Phone }).ToList();

            foreach(var item in value)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.Key);
            }
            //Console.WriteLine(string.Join(", ", value));


            /*var students = new List<Student>
              {
                  new Student { Name = "Nandha", Class = "10A" },
                  new Student { Name = "Ajay", Class = "10B" },
                  new Student { Name = "Kumar", Class = "10A" },
                  new Student { Name = "Subash", Class = "10B" },
                  new Student { Name = "Ravi", Class = "10C" }
              };

            var groupedStudents = students.GroupBy(s => s.Class);

            foreach(var group in groupedStudents)
            {
                Console.WriteLine($"Class: {group.Key}");
                foreach(var student in group)
                {
                    Console.WriteLine($"  Student: {student.Name}");
                }
            }*/

        }

    }
}
