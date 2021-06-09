using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }
        public void Add(Pet pet)
        {
            if (Capacity > data.Count)
            {
                data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet petToremove = data.FirstOrDefault(x => x.Name == name);
            if (petToremove != null)
            {
                data.Remove(petToremove);
                return true;
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            Pet toGive = data.FirstOrDefault(x => x.Name == name
            && x.Owner == owner);
            return toGive;
        }
        public Pet GetOldestPet()
        {
                Pet oldest = data.OrderByDescending(x => x.Age).FirstOrDefault();
                return oldest;
        }
        //public int Count()
        //{
        //    int neshto = 0;
        //    foreach (var pet in data)
        //    {
        //        neshto++;
        //    }
        //    return neshto;
       // }
        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The clinic has the following patients:");
            foreach (var pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}".ToString());
            }
            return result.ToString();
        }
    }
}
