using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Clothes : Product
    {
        public Clothes(string name, string brand, decimal price) : base(name, brand, price)
        {
        }
        public SizeEnum Size { get; set; }
        public ColorEnum Color { get; set; }
    }
}
