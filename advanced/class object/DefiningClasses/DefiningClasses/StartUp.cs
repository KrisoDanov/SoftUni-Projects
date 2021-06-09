using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family newFamily = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split();
                Person newPerosn = new Person(array[0], int.Parse(array[1]));
                newFamily.AddMember(newPerosn);
            }
            Person[] oldestPerson = newFamily.GetPeople();
            foreach (var item in oldestPerson)
            {
            Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
