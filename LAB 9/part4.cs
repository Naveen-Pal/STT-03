using System;

namespace ArrayConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { 45, 12, 54 },
                { 10, 23, 6 },
                { 0, 18, 79 },
                { 91, 27, 33   }
            };

           
            Console.WriteLine("Original 2D Array:");
            Print2D(matrix); 
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[] rowMajor = new int[rows * cols];
            int[] colMajor = new int[rows * cols];

            int index = 0;

            // Row Major Order
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rowMajor[index++] = matrix[i, j];
                }
            }
            Console.WriteLine("\nRow Major Order (1D Array):");
            Print1D(rowMajor);


            index = 0;
            // Column Major Order
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    colMajor[index++] = matrix[i, j];
                }
            }
            Console.WriteLine("\nColumn Major Order (1D Array):");
            Print1D(colMajor);
        }

        static void Print2D(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Print1D(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}