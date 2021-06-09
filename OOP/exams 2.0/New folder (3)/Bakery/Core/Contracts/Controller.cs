using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core.Contracts
{
    class Controller : IController
    {

        private readonly List<Table> resturantTables;
        private readonly List<BakedFood> resturantFood;
        private readonly List<Drink> resturantDrinks;

        public Controller()
        {
            resturantTables = new List<Table>();
            resturantFood = new List<BakedFood>();
            resturantDrinks = new List<Drink>();
        }
        public string AddDrink(string type, string name, int portion, string brand)
        {
            Drink drink = null;
            if (type == "Tea")
            {
                drink = new Tea(name, portion, brand);
            }
            if (type == "Water")
            {
                drink = new Water(name, portion, brand);
            }
            resturantDrinks.Add(drink);
            return $"Added {name} ({brand}) to the drink menu";
        }

        public string AddFood(string type, string name, decimal price)
        {
            BakedFood food = null;
            if (type == "Bread")
            {
                food = new Bread(name, price);
            }
            if (type == "Cake")
            {
                food = new Cake(name, price);
            }
            resturantFood.Add(food);
            return $"Added {name} ({type}) to the menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            Table table = null;
            if (type == "OutsideTable")
            {
                table = new OutsideTable(tableNumber, capacity);
            }
            if (type == "InsideTable")
            {
                table = new InsideTable(tableNumber, capacity);
            }
            resturantTables.Add(table);
            return $"Added table number {tableNumber} in the bakery";
        }

        public string GetFreeTablesInfo()
        {
            var totalincome = 0.00m;
            foreach (var item in resturantTables)
            {
                totalincome = item.Price + item.GetBill();
            }
            return $"Total income: {totalincome:f2}lv";
        }

        public string GetTotalIncome()
        {
            foreach (var item in resturantTables)
            {
                if (item.IsReserved == false)
                {
                   return item.GetFreeTableInfo();
                }
            }
            return "";
        }

        public string LeaveTable(int tableNumber)
        {
            var currTable = resturantTables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var bill = currTable.GetBill();

            currTable.Clear();

            return $"Table: {tableNumber}" + Environment.NewLine + $"Bill: {bill:f2}";



        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var currTable = resturantTables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var currDrink = resturantDrinks.FirstOrDefault(x => x.Brand == drinkBrand);
            if (currDrink == null)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }
            if (currTable == null)
            {

                return $"Could not find table {tableNumber}";
            }
            else
            {
                currTable.OrderDrink(currDrink);
                return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
            }

        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var currTable = resturantTables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var currFood = resturantFood.FirstOrDefault(x => x.Name == foodName);
            if (currFood == null)
            {
                return $"No {foodName} in the menu";
            }
            if (currTable == null)
            {
                return $"Could not find table {tableNumber}";
            }
            else
            {
                currTable.OrderFood(currFood);
                return $"Table {tableNumber} ordered {foodName}";
            }
        }

        public string ReserveTable(int numberOfPeople)
        {

            foreach (var item in resturantTables)
            {
                if (item.IsReserved == true && item.NumberOfPeople >= numberOfPeople)
                {

                    return $"Table {item.TableNumber} has been reserved for {numberOfPeople} people";

                }

            }
            return $"No available table for {numberOfPeople} people";
        }
    }
}
