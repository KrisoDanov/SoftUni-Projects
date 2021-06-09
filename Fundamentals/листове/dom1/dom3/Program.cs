using System;
using System.Collections.Generic;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ProceedComand(people);
            }

            printpeople(people);
        }

        private static void printpeople(List<string> people)
        {
            foreach (var perosn in people)
            {
                Console.WriteLine(perosn);
            }
        }

        private static void ProceedComand(List<string> people)
        {
            string command = Console.ReadLine();

            string[] cmdArgs = command
                .Split(' ', 2)
                .ToArray();

            string name = cmdArgs[0];
            if (cmdArgs.Length == 3)
            {
                AddPerson(people, name);
            }
            else if (cmdArgs.Length == 4)
            {
                removeFirst(people, name);
            }
        }

        private static void removeFirst(List<string> people, string name)
        {
            if (people.Contains(name))
            {
                people.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list");
            }
        }

        private static void AddPerson(List<string> people, string name)
        {
            if (people.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list");
            }
            else
            {
                people.Add(name);
            }
        }
    }
}
