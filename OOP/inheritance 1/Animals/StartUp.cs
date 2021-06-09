using System;

namespace Animals
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            string command1 = Console.ReadLine();
            string command2 = Console.ReadLine();

            while (command1 != "Beast!")
            {
                string[] splittedComand2 = command2.Split();
                if (command1 == "Cat")
                {
                    Cat cat = new Cat(splittedComand2[0], 
                        int.Parse(splittedComand2[1]), splittedComand2[2]);
                    //Console.WriteLine($"{cat.Name} {cat.Age} {cat.Gender}");
                    
                    Console.WriteLine(cat.ProduceSound());
                }
                if (command1 == "Dog")
                {
                    Dog dog = new Dog(splittedComand2[0],
                        int.Parse(splittedComand2[1]), splittedComand2[2]);
                  //  Console.WriteLine($"{dog.Name} {dog.Age} {dog.Gender}");
                    Console.WriteLine(dog.ProduceSound());
                }
                if (command1 == "Frog")
                {
                    Frog frog = new Frog(splittedComand2[0],
                        int.Parse(splittedComand2[1]), splittedComand2[2]);
                   // Console.WriteLine($"{frog.Name} {frog.Age} {frog.Gender}");

                    Console.WriteLine(frog.ProduceSound());
                }

                command1 = Console.ReadLine();
                command2 = Console.ReadLine();
            }
        }
    }
}
