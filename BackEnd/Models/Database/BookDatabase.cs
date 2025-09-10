using CSharp.CommonUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.CommonUtils.Database
{
    public class BookDatabase
    {

        public static List<Book> GetBookDatabase() 
        {
        return new List<Book>
        {
            new Book { ID = 1, Title = "C# in Depth", Author = "Jon Skeet", Genre = "Programming", YearPublished = 2019, Price = 45.50 },
            new Book { ID = 2, Title = "Clean Code", Author = "Robert C. Martin", Genre = "Programming", YearPublished = 2008, Price = 39.99 },
            new Book { ID = 3, Title = "The Pragmatic Programmer", Author = "Andy Hunt", Genre = "Programming", YearPublished = 1999, Price = 42.00 },
            new Book { ID = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", YearPublished = 1937, Price = 25.00 },
            new Book { ID = 5, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Genre = "Fantasy", YearPublished = 1997, Price = 29.99 },
            new Book { ID = 6, Title = "1984", Author = "George Orwell", Genre = "Dystopian", YearPublished = 1949, Price = 19.99 },
            new Book { ID = 7, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", YearPublished = 1960, Price = 22.50 }
        };
        }
        
    }
}
