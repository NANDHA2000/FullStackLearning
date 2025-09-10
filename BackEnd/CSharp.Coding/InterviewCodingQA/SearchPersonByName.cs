using CSharp.CommonUtils.Database;

namespace CSharp.Coding.InterviewCodingQA
{
    public class SearchPersonByName
    {
        public static void SearchPersonByNameEx()
        {
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
    }
}
