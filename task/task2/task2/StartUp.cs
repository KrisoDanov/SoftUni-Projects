using System;

namespace task2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Product shirt = new Clothes("shirt", "shirt", 15);
            Product food = new Food("banana", "banana", 15, DateTime.Parse("10/10/2021"));
            Product laptop = new Appliance("acer", "acer", 150, "acer", DateTime.Parse("10/10/2020"), 1);

            FinalOrder finalOrder = new FinalOrder();

            finalOrder.Products.Add(shirt);
            finalOrder.Products.Add(food);
            finalOrder.Products.Add(laptop);

            Cahsier cahsier = new Cahsier();
            Console.WriteLine(cahsier.WriteTheOrder(finalOrder));
        }
    }
}
