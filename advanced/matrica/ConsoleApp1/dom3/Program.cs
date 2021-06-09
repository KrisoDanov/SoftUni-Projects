using System;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            fillMatrix(matrix);
            int sum = 0;
            int firstindex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int num = matrix[row, col];
                    int num2 = matrix[row, col + 1];
                    int num3 = matrix[row, col + 2];
                    int num4 = matrix[row + 1, col];
                    int num5 = matrix[row + 1, col + 1];
                    int num6 = matrix[row + 1, col + 2];
                    int num7 = matrix[row + 2, col];
                    int num8 = matrix[row + 2, col + 1];
                    int num9 = matrix[row + 2, col + 2];
                    int sumAll = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum < sumAll)
                    {
                        sum = sumAll;
                        firstindex = matrix[row, col];

                        

                        }
                    
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int row = firstindex; row < firstindex + 3; row++)
            {
               
                for (int col = firstindex; col < firstindex + 3 ; col++)
                {
                    Console.Write(string.Join(" ", matrix[row, col]));
                }
                Console.WriteLine();
            }


        }
        private static void fillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var fillMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillMatrix[col];
                }
            }
        }
    }
}
