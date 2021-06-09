using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int bRow = -1;
            int bCol = -1;
            int flour = 0;
            


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'B')
                    {
                        bRow = row;
                        bCol = col;
                        matrix[bRow, bCol] = '.';
                    }
                }
            }
            string command = Console.ReadLine();
            bool isOutSide = true;
            while (command != "End")
            {

                if (command == "up")
                {
                    if ((bRow - 1) >= 0)
                    {
                        bRow--;
                        if (matrix[bRow, bCol] == 'f')
                        {
                            flour++;
                            matrix[bRow, bCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        isOutSide = false;
                        break;
                    }
                }
                else if (command == "down")
                {
                    if ((bRow + 1) < matrix.GetLength(0))
                    {
                        bRow++;
                        if (matrix[bRow, bCol] == 'f')
                        {
                            flour++;
                            matrix[bRow, bCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        isOutSide = false;
                        break;
                    }
                }
                else if (command == "left")
                {
                    if ((bCol - 1) >= 0)
                    {
                        bCol--;
                        if (matrix[bRow, bCol] == 'f')
                        {
                            flour++;
                            matrix[bRow, bCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        isOutSide = false;
                        break;
                    }
                }
                else if (command == "right")
                {
                    if ((bCol + 1) < matrix.GetLength(1))
                    {
                        bCol++;
                        if (matrix[bRow, bCol] == 'f')
                        {
                            flour++;
                            matrix[bRow, bCol] = '.';
                        }
                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        isOutSide = false;
                        break;
                    }

                }


                if (matrix[bRow, bCol] == 'O')
                {
                    matrix[bRow, bCol] = '.';
                    if (command == "up")
                    {
                        if ((bRow - 1) >= 0)
                        {
                            bRow--;
                            if (matrix[bRow, bCol] == 'f')
                            {
                                flour++;
                                matrix[bRow, bCol] = '.';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isOutSide = false;
                            break;
                        }
                    }
                    else if (command == "down")
                    {
                        if ((bRow + 1) < matrix.GetLength(0))
                        {
                            bRow++;
                            if (matrix[bRow, bCol] == 'f')
                            {
                                flour++;
                                matrix[bRow, bCol] = '.';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isOutSide = false;
                            break;
                        }

                    }
                    else if (command == "left")
                    {
                        if ((bCol - 1) >= 0)
                        {

                            bCol--;
                            if (matrix[bRow, bCol] == 'f')
                            {
                                flour++;

                                matrix[bRow, bCol] = '.';
                            }
                            else
                            {
                                Console.WriteLine("The bee got lost!");
                                isOutSide = false;
                                break;
                            }

                        }

                    }
                    else if (command == "right")
                    {
                        if ((bCol + 1) < matrix.GetLength(1))
                        {
                            bCol++;
                            if (matrix[bRow, bCol] == 'f')
                            {
                                flour++;
                                matrix[bRow, bCol] = '.';
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            isOutSide = false;
                            break;
                        }

                    }


                }
                

                command = Console.ReadLine();
            }
            if (flour >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flour} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flour} flowers more");
            }
            if (isOutSide)
            {
                
            matrix[bRow, bCol] = 'B';
            }
            Print(matrix);
        }
        public static void Print(char[,] matrix)
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
