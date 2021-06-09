using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            string[] comands = Console.ReadLine().Split(',');
            int friendlyShips = 0;
            int enemyships = 0;

            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == '<')
                    {
                        friendlyShips++;
                    }
                    if (matrix[row, col] == '>')
                    {
                        enemyships++;
                    }
                }
            }
            int count1 = friendlyShips;
            int count2 = enemyships;
            foreach (var item in comands)
            {
                string[] splitted = item.Split(' ');
                int postion1 = int.Parse(splitted[0]);
                int postion2 = int.Parse(splitted[1]);
                try
                {
                    if (matrix[postion1, postion2] == '<')
                    {
                        friendlyShips--;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    continue;
                }
                try
                {
                    if (matrix[postion1, postion2] == '>')
                    {
                        enemyships--;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    continue;
                }
                //hereeeeeeeeeeeeeeeeeee
                if (matrix[postion1, postion2] == '#')
                {
                    try
                    {
                        if (matrix[postion1 + 1, postion2 + 1] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }

                    try
                    {
                        if (matrix[postion1 + 1, postion2] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2 + 1] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1, postion2 - 1] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1, postion2 + 1] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2 - 1] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2 + 1] == '<')
                        {
                            friendlyShips--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }

                    //gereeeeeeeeeeeeeeeeeeeeee
                    try
                    {
                        if (matrix[postion1 + 1, postion2 + 1] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }

                    try
                    {
                        if (matrix[postion1 + 1, postion2] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2 + 1] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1, postion2 - 1] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1, postion2 + 1] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2 - 1] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                    try
                    {
                        if (matrix[postion1 - 1, postion2 + 1] == '>')
                        {
                            enemyships--;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                }


                if (friendlyShips == 0)
                {
                    Console.WriteLine("Player Two has won the game!");
                    Console.WriteLine($"{count1} ships have been sunk in the battle.");
                    break;
                }
                if (enemyships == 0)
                {
                    Console.WriteLine("Player One has won the game!");
                    Console.WriteLine($"{count2} ships have been sunk in the battle.");
                    break;
                }
            }
        }
        static void Print(char[,] matrix)
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


