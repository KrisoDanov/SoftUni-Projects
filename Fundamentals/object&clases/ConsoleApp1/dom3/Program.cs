using System;
using System.Collections.Generic;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> list = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Students separate = new Students(input[0], input[1], double.Parse(input[2]));
                list.Add(separate);
            }

            List<Students> sortedClass = list.OrderByDescending(a => a.Grade).ToList();

            foreach (var student in sortedClass)
            {
                Console.WriteLine($"{student.FirstName} {student.SecondName}: {student.Grade:F2}");
            }

        }
    }
    class Students
    {
        public Students(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

    }
}
