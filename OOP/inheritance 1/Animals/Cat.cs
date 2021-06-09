using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Cat(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return "Meow meow!";
        }
    }
}
