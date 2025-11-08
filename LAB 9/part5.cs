using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = {
                { 4,8,12 },
                { 5,10,15 }
            };
            int[,] B = {
                { 2,4 },
                { 12,14 },
                { 22,24 }
            };

            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);

            if (colsA != rowsB) {
                Console.WriteLine("Matrix multiplication not possible. Columns of A must equal rows of B.");
                return;
            }

            int[,] C = new int[rowsA, colsB];
            // Matrix multiplication logic
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            Console.WriteLine("Matrix A:");
            PrintMatrix(A);
            Console.WriteLine("\nMatrix B:");
            PrintMatrix(B);

            Console.WriteLine("\nResultant Matrix C (A × B):");
            PrintMatrix(C);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}