using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    internal class MyMatrix
    {
        int[,] matrix;
        int rows;
        int cols;

        public MyMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = random.Next(0, 100);
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }
        }
        public void PrintDerivedMatrixs()
        {
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                Console.WriteLine($"\nПохідна матриця {rows - i}x{cols - i}:");
                for (int j = 0; j < rows - i; j++)
                {
                    for (int k = 0; k < cols - i; k++)
                        Console.Write($"{ matrix[j, k],4}");
                    Console.WriteLine();
                }
            }
        }
    }
}
