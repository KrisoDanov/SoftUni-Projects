using System;
using System.Collections.Generic;
using System.Text;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Backpack : Bag
    {
        private const int BackpackCapacoty = 100;
        public Backpack() 
            : base(BackpackCapacoty)
        {

        }
    }
}
