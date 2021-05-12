using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courseStudents =
                new Dictionary<string, string>();
            string input = Console.ReadLine();
            int people = 0;
            while (input != "end")
            {

                List<string> splitted = input.Split(" : ").ToList();

                if (courseStudents.ContainsKey(splitted[0]))
                {
                    courseStudents[splitted[0]] += splitted[1];
                    people++;
                }
                if (!courseStudents.ContainsKey(splitted[0]))
                {
                    courseStudents.Add(splitted[0], splitted[1]);
                    people = 0;
                }
                input = Console.ReadLine();
            }


            foreach (var person in courseStudents)
            {
                Console.WriteLine($"{person.Key} : {people}");

                    Console.WriteLine($"-- {person.Value}");
                
               
            }
        }
    }
}
