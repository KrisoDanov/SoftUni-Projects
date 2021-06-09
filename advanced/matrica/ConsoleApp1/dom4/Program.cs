using System;
using System.Linq;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[n[0], n[1]];
            fillMatrix(matrix);
            string input = Console.ReadLine();
            while (input != "END")
            {
                    var split = input.Split().ToArray();
                if (split.Length > 4)
                {

                    int indexone = int.Parse(split[1]);
                    int indextwo = int.Parse(split[2]);
                    int indexthree = int.Parse(split[3]);
                    int indexfour = int.Parse(split[4]);

                    if (input.Contains("swap")
                        && indexone < matrix.GetLength(0) ||
                          indexthree < matrix.GetLength(0) ||
                          indexfour < matrix.GetLength(1) ||
                         indextwo < matrix.GetLength(1))
                    {
                        string firstEl = matrix[indexone, indextwo];
                        string secondEl = matrix[indexthree, indexfour];
                        matrix[indexthree, indexfour] = firstEl;
                        matrix[indexone, indextwo] = secondEl;
                        PrintMatrix(matrix);

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                    input = Console.ReadLine();
            }

        }
        private static void fillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var fillMatrix = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillMatrix[col];
                }
            }
        }
        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
