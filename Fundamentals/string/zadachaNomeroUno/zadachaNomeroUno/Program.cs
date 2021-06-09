using System;

namespace zadachaNomeroUno
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                char[] currentL = input[i].ToCharArray();
                if (input[i].Length > 6 && input[i].Length < 16)
                {
                    char curr = currentL[i];
                    for (int j = 0;j < input[i].Length; j++)
                    {
                        

                        if (char.IsLetterOrDigit(curr) && curr != '-'
                            && curr != '_' && curr!= '@')
                        {
                            Console.Write(curr);
                        }
                    }
                }
            }
        }
    }
}
