using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CommonUtils.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Class { get; set; }

        public int Marks { get; set; }
        public int? CompareTo(Student other) => Marks.CompareTo(other.Marks);

    }
}
