using EasterRaces.Models.Races.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Contracts
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly List<IRace> races;
        public RaceRepository()
        {
            this.races = new List<IRace>();
        }
        public void Add(IRace model)
        => races.Add(model);

        public IReadOnlyCollection<IRace> GetAll()
        => races.ToArray();

        public IRace GetByName(string name)
        => races.FirstOrDefault(x => x.Name == name);

        public bool Remove(IRace model)
        => races.Remove(model);
    }


}
