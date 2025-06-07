using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics_Fundamentals.ProblemStatementProgram
{
    public class MatrixTransversal
    {

        public static Dictionary<string, string> DirectionalPatternMatchInGrid()
        {

            /*int[] input = new int[] { 1, 2, 8, 9, 9, 7, 6, 4, 3, 2, 1, 7, 9, 7, 6, 0 };
            int length = input.Length;

            Console.WriteLine(length);

            int rows = 4;
            int cols = 4;


            int[,] matrix = new int[rows, cols];

            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[index++];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }



            *//*            foreach(int num in input)
                        {
                            Console.WriteLine(num);
                        }*//*


            Dictionary<string, string> values = new Dictionary<string, string>() { { "Alpha", "2R8R9D7L8" },{ "Beta","1D9D3R2U7"},
                { "Gamma", "2R8U7L3" },{"Zeta", "0U5R9D1" }
            };

            foreach(var item in values)
            {
                Console.WriteLine(item);
            }
            
            return values;
        }*/

            int[] input = new int[] { 1, 2, 8, 9, 9, 7, 6, 4, 3, 2, 1, 7, 9, 7, 6, 0 };
            int rows = 4;
            int cols = 4;

            int[,] matrix = new int[rows, cols];

            // Fill the matrix
            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[index++];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Directional patterns
            Dictionary<string, string> directions = new Dictionary<string, string>()
        {
            { "Alpha", "2R8R9D7L8" },
            { "Beta", "1D9D3R2U7" },
            { "Gamma", "2R8U7L3" },
            { "Zeta",  "0U5R9D1" }
        };

            Dictionary<string, string> results = new Dictionary<string, string>();

            // Loop through each pattern
            foreach(var pattern in directions)
            {
                string name = pattern.Key;
                string path = pattern.Value;

                // Get starting digit's position
                int startDigit = int.Parse(path[0].ToString());
                bool found = false;
                int startRow = -1, startCol = -1;

                for(int i = 0; i < rows && !found; i++)
                {
                    for(int j = 0; j < cols && !found; j++)
                    {
                        if(matrix[i, j] == startDigit)
                        {
                            startRow = i;
                            startCol = j;
                            found = true;
                        }
                    }
                }

                if(!found)
                {
                    results[name] = "Start digit not found";
                    continue;
                }

                string match = startDigit.ToString();
                int r = startRow, c = startCol;

                for(int i = 1; i < path.Length; i += 2)
                {
                    char direction = path[i];
                    int nextDigit = int.Parse(path[i + 1].ToString());

                    // Move in the direction
                    switch(direction)
                    {
                        case 'U': r--; break;
                        case 'D': r++; break;
                        case 'L': c--; break;
                        case 'R': c++; break;
                    }

                    // Check boundaries
                    if(r < 0 || r >= rows || c < 0 || c >= cols)
                    {
                        match = "Out of bounds";
                        break;
                    }

                    if(matrix[r, c] != nextDigit)
                    {
                        match = $"Mismatch at ({r},{c})";
                        break;
                    }

                    match += nextDigit.ToString();
                }

                results[name] = match;
            }

            return results;
        }
    }
}
