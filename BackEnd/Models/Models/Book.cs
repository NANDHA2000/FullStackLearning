using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CommonUtils.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int YearPublished { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Book Title: {Title}, Author: {Author}, Price: {Price}, Published: {YearPublished}, Genre: {Genre}";
        }
    }
}
