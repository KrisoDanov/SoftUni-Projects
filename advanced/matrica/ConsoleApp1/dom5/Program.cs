using System;
using System.Linq;

namespace dom5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0], n[1]];
            //fillMatrix(matrix);
            int index = 0;
            string input = Console.ReadLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = input[index];
                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = n[1] - 1; matrix.GetLength(1) >= 0; col--)
                    {
                        matrix[row, col] = input[index];
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                        index++;
                    }
                }
            
            }
            PrintMatrix(matrix);
        }
        private static void fillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] fillMatrix = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillMatrix[col];
                }
            }
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}
