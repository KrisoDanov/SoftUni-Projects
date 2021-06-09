using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;
            int food = 0;
            int b1Row = -1;
            int b1Col = -1;
            int b2Row = -1;
            int b2Col = -1;
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'S')
                    {
                        matrix[row, col] = '.';
                        snakeRow = row;
                        snakeCol = col;
                    }
                    if (matrix[row, col] =='B')
                    {
                        if (b1Row == -1)
                        {
                            b1Row = row;
                            b1Col = col;
                        }
                        else
                        {
                            b2Row = row;
                            b2Col = col;
                        }
                    }
                }
            }
            string comand = Console.ReadLine();
            while (true)
            {
                
                if (comand == "up")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    try
                    {
                        snakeRow -= 1;
                    }
                    catch (Exception)
                    {

                        break;
                    }
                    
                }
                if (comand == "down")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    try
                    {
                        snakeRow += 1;
                    }
                    catch (Exception)
                    {

                        break;
                    }
                    
                }
                if (comand == "left")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    try
                    {
                        snakeCol -= 1;
                    }
                    catch (Exception)
                    {

                        break;
                    }
                    
                }
                if (comand == "right")
                {
                    matrix[snakeRow, snakeCol] = '.';
                    try
                    {
                        snakeCol += 1;
                    }
                    catch (Exception)
                    {

                        break;
                    }
                    
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    food++;
                    if (food == 10)
                    {
                        Console.WriteLine("You won! You fed the snake.");
                        break;
                    }
                }
                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (matrix[snakeRow, snakeCol] == matrix[b1Row, b1Col])
                    {
                        matrix[snakeRow, snakeCol] = matrix[b2Row, b2Col];
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = matrix[b1Row, b1Col];
                    }
                }
                
                comand = Console.ReadLine();
                
            }
            matrix[snakeRow, snakeCol] = 'S';
            if (food < 10)
            {
                Console.WriteLine("Game over!");

            }
            Console.WriteLine($"Food eaten: {food}");
            Print(matrix);
        }
        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
