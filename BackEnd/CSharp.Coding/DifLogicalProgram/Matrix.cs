using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Coding.DifLogicalProgram
{
    public class Matrix
    {

        public void DisplayMatrix(int[] array, int rows, int cols)
        {
            // Validate input
            if(array.Length != rows * cols)
            {
                Console.WriteLine("The array size does not match the specified matrix dimensions.");
            }

            // Create the matrix
            int[,] matrix = new int[rows, cols];

            // Fill the matrix from the array
            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = array[index++];
                }
            }

            // Display the matrix
            Console.WriteLine("Matrix:");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}

