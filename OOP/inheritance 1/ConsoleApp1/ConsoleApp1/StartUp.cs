using System;

namespace ConsoleApp1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age < 15)
            {
                Person person = new Child(name, age);
            }
            else
            {
                Person person = new Person(name, age);
            }
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
