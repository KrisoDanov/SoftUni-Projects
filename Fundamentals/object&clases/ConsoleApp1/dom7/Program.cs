using System;
using System.Collections.Generic;
using System.Linq;

namespace dom7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                string[] people = Console.ReadLine().Split(" ");
                if (people[0] == "End")
                {
                    break;
                }
                Person separate = new Person(people[0], people[1], double.Parse(people[2]));

              
                list.Add(separate);

            }
            List<Person> sortedPeople = list.OrderByDescending(a => a.Age).ToList();

            
                Console.WriteLine(string.Join(Environment.NewLine, sortedPeople)); 

        }
    }
    class Person
    {
        public Person(string firstName, string id, double age)
        {
            this.FirstName = firstName;
            this.Id = id;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public double Age { get; set; }

    }
}
