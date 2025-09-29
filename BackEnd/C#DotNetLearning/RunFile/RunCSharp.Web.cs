using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.RunFile
{
    public class RunCSharpWeb
    {
        public static async Task Run()
        {
            using var client = new HttpClient();

            try
            {
                // Call API running on different port (cross-origin scenario)
                var response = await client.GetAsync("http://localhost:5001/hello");
                var content = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Response from API: {content}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Request failed: {ex.Message}");
            }
        }
    }
}
