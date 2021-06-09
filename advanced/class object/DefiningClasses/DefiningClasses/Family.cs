using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> People;
        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldestPerson = new Person();
            People = People.Where(x => x.Age > 30).OrderByDescending(x => x.Age).ToList();
            oldestPerson = People.FirstOrDefault();
            return oldestPerson;
        }
        public Person[] GetPeople()
        {
            
            var people = People.Where(x => x.Age > 30).OrderBy(x => x.Name).ToArray();
            return people;
        }
    }
}
