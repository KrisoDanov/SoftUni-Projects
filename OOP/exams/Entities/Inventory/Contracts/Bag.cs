using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory.Contracts
{
    public abstract class Bag : IBag
    {
        private int BagCapacity = 100;
        private List<Item> itemsCapacity;

        
        public Bag(int bagCapacity)
        {
            itemsCapacity = new List<Item>();
            Capacity = bagCapacity;
        }
        
        public int Capacity
        {
            get => BagCapacity;
            set
            {
                BagCapacity = value;
            }
        }

        public int Load => itemsCapacity.Count * 5;

        public IReadOnlyCollection<Item> Items => itemsCapacity.AsReadOnly();

        public void AddItem(Item item)
        {
            if (Load > 100)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            itemsCapacity.Add(item);
        }

        public Item GetItem(string name)
        {
            if (Load <= 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
            Item item = itemsCapacity.FirstOrDefault(x => x.GetType().Name == name);
            if (item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
            itemsCapacity.Remove(item);
            return item;
        }
    }
}
