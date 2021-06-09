using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage
{
    public class Citizen : IResident, IPerosn
    {
        public string Name { get; set; }

        public string Country { get ; set ; }
        public int Age { get ; set; }
        public Citizen(string name)
        {
            this.Name = name;
        }

         string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
        string IPerosn.GetName()
        {
            return $"{this.Name}";
        }
    }
}
