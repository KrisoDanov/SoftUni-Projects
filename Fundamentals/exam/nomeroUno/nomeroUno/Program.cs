using System;

namespace nomeroUno
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] splitted = input.Split(">>>");
                if (input.Contains("Contains"))
                {
                    if (password.Contains(splitted[1]))
                    {
                        Console.WriteLine($"{password} contains {splitted[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                if (input.Contains("Flip"))
                {
                    if (input.Contains("Upper"))
                    {
                        password = password.Substring(int.Parse(splitted[2]), int.Parse(splitted[3])
                            .ToUpper();
                        Console.WriteLine(password);
                        
                    }
                    if (input.Contains("Lower"))
                    {
                        password = password.Substring(int.Parse(splitted[2]), int.Parse(splitted[3]))
                            .ToLower();
                        Console.WriteLine(password);
                    }
                }
                if (input.Contains("Slice"))
                {
                    password = password.Remove(int.Parse(splitted[1]), int.Parse(splitted[2]));
                    Console.WriteLine(password);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {password}");
        }
    }
}
