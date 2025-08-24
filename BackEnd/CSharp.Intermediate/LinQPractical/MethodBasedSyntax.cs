using CSharp.CommonUtils.Database.LinQ;
using CSharp.CommonUtils.Models;

namespace CSharp.Intermediate.LinQPractical
{
    public class MethodBasedSyntax
    {

        private readonly List<Book> book = BookDatabase.GetBookDatabase();

        #region Select
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
        #endregion

        #region Where
        // 2.Where 

        public void WhereEx()
        {
            var output = book.Where(p => p.Price > 1).ToList();

            output.ForEach(p => Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price}"));
        }
        #endregion

        #region Orderby
        // 3.Order by (Asc or Desc)

        public void OrderByEx()
        {
            //Single Order by

            var output = book.OrderBy(p => p.Price).ToList(); //Asc

            //var output = book.OrderByDescending(p => p.Price).ToList(); //Desc

            output.ForEach(p => Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price}"));

            //Multiple Order by

            var output1 = book.OrderBy(p => p.Price).ThenBy(p => p.YearPublished).ToList(); //Asc

            //var output1 = book.OrderByDescending(p => p.Price).ThenBy(p => p.YearPublished).ToList(); //Desc

            output1.ForEach(p => Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price},Published: {p.YearPublished}"));
        }
        #endregion


        //4.GroupBy

        public void GroupByEx()
        {
            var output = book.GroupBy(p => p.Price).Select(g => new { Price = g.Key ,Total = g.Count() }).ToList();

            output.ForEach(p => Console.WriteLine($"Price: {p.Price}, Author: {p.Total}"));
        }
    }
}
