using CSharp.CommonUtils.Database.LinQ;
using CSharp.CommonUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Intermediate.LinQPractical
{
    public class MethodBasedSyntax
    {

        private readonly List<Book> book = BookDatabase.GetBookDatabase();

        // 1.Select 

        public void SelectEx() 
        {
            

            var output = book.Select(p => (p.ID, p.Author)).ToList();

            output.ForEach(p => Console.WriteLine(p.ToTuple())); //Instead of foreach we can use this way

            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            /*  ---------  */

            var output2 = book.Select(p => new
            {

                AuthorID = p.ID,
                AuthorName = p.Author

            }).ToList();

            output2.ForEach(p => Console.WriteLine(p));
        }

        // 2.Where 

        public void WhereEx() 
        {
            var output = book.Where(p => p.Price > 1).ToList();

            output.ForEach(p => Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price}"));
        }


        // 3.Order by (Asc or Desc)

        public void OrderByEx()
        {
            //Single Order by

            var output = book.OrderBy(p => p.Price).ToList();

            output.ForEach(p => Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price}"));

            //Multiple Order by

            var output1 = book.OrderBy(p => p.Price).ThenBy(p => p.YearPublished).ToList();

            output1.ForEach(p => Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price},Published: {p.YearPublished}"));
        }
    }
}
