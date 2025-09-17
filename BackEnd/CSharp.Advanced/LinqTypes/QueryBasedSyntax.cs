using CSharp.CommonUtils.Database;
using CSharp.CommonUtils.Models;

namespace CSharp.Advanced.LinqTypes
{
    public class QueryBasedSyntax
    {
        private readonly List<Book> book = BookDatabase.GetBookDatabase();

        #region Select
        // 1.Select 

        public void SelectEx()
        {
            //var book = BookDatabase.GetBookDatabase();

            var output = from p in book select (p.ID, p.Author); //( ) -- Concept tuple

            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            /* ----------- */

            var output2 = from p in book select new { p.ID, p.Author };

            foreach(var item in output2)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Where
        // 2.Where

        public void WhereEx()
        {
            var output = from p in book where p.Price > 1 select p;

            foreach(var p in output)
            {
                Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price}");
            }
        }
        #endregion

        #region Orderby
        // 3.Order by (Asc Or Desc)

        public void OrderByEx()
        {
            var output = from p in book orderby p.Genre, p.Author select p;

            foreach(var p in output)
            {
                Console.WriteLine($"ID: {p.ID}, Author: {p.Author}, Price: {p.Price},Published: {p.YearPublished},Genre: {p.Genre}");
            }
        }
        #endregion

    }
}
