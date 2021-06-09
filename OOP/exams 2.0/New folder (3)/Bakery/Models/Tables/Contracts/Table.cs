using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Models.Tables.Contracts
{
    public abstract class Table : ITable
    {
        private ICollection<IBakedFood> foodOrders;
        private ICollection<IDrink> drinkOrders;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            foodOrders = new List<IBakedFood>();
            drinkOrders = new List<IDrink>();
        }

        public IReadOnlyCollection<IBakedFood> FoodOrders => (IReadOnlyCollection<BakedFood>)foodOrders;
        public IReadOnlyCollection<IDrink> DrinkOrders => (IReadOnlyCollection<Drink>)drinkOrders;

        public int TableNumber { get; set; }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                capacity = value;
            }
        }


        private int numberOfPeople;

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                numberOfPeople = value;
            }
        }



        public decimal PricePerPerson { get; set; }

        public bool IsReserved { get; set; }

        public decimal Price => PriceForTheTable(numberOfPeople, PricePerPerson);

        public void Clear()
        {
            foodOrders.Clear();
            drinkOrders.Clear();
            NumberOfPeople = 0;
            IsReserved = false;
        }

        public decimal GetBill()
        {
            decimal resultOne = 0;
            foreach (var item in FoodOrders)
            {
                resultOne += item.Price;
            }
            decimal resultWto = 0;
            foreach (var item in DrinkOrders)
            {
                resultWto += item.Price;
            }

            var finalResult = resultOne + resultWto;
            return finalResult;

        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson}");
            return sb.ToString().TrimEnd();
      }

        public void OrderDrink(IDrink drink)
        {
            drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            if (IsReserved == false)
            {
                if (capacity >= numberOfPeople)
                {
                    IsReserved = true;
                }
            }
        }
        private decimal PriceForTheTable(int numberOfPeople, decimal pricePerPerson)
        {
            var result = numberOfPeople * pricePerPerson;
            return result;
        }
    }
}
