using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class arrayoperations
    {
        // Implements the bubble sort algorithm as required
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Last i elements are already in place
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the element found is greater
                    // than the next element
                    if (arr[j] > arr[j + 1])
                    {
                        // Perform swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        
        // Stores a 2D array in row-major order
        public int[] ConvertTo1DRowMajor(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] arr = new int[rows * cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i * cols + j] = matrix[i, j];
                }
            }
            return arr;
        }

        // Stores a 2D array in column-major order
        public int[] ConvertTo1DColumnMajor(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] arr = new int[rows * cols];

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    arr[j * rows + i] = matrix[i, j];
                }
            }
            return arr;
        }
        // Performs multiplication of two matrices
        public int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int colsB = matrixB.GetLength(1);

            // Matrix multiplication is only possible if
            // columns in A == rows in B
            if (colsA != rowsB)
            {
                Console.WriteLine("Error: Matrices dimensions are not valid for multiplication.");
                return null; // Return null to indicate failure
            }

            // The resulting matrix C
            int[,] matrixC = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++) // Loop for C's rows
            {
                for (int j = 0; j < colsB; j++) // Loop for C's columns
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < colsA; k++) // Loop for sum of products
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrixC;
        }


        // 'static' means we can call it without creating an object
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }


        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // \t adds a tab for better spacing
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("]");
            }
        }
    }
}