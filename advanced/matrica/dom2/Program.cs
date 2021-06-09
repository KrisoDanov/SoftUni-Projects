using System;
using System.Linq;

namespace dom2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0], n[1]];
            fillMatrix(matrix);
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currRow = matrix[row, col];
                    char currRow1 = matrix[row + 1, col];
                    char currCol = matrix[row, col+ 1];
                    char currCol1 = matrix[row + 1, col+1];
                    
                    if (currRow == currRow1 && currRow == currCol && currRow == currCol1)
                    {
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);
            static void fillMatrix(char[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    var fillMatrix = Console.ReadLine().Split().Select(char.Parse).ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = fillMatrix[col];
                    }
                }

            }
        }
    }
}
