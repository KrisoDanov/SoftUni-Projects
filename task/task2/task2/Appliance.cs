using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Appliance : Product
    {
        public Appliance(string name, string brand, decimal price, string model, DateTime productionDate, int weight) : base(name, brand, price)
        {
            Model = model;
            ProductionDate = productionDate;
            Weight = weight;
        }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Weight { get; set; }
    }
}
