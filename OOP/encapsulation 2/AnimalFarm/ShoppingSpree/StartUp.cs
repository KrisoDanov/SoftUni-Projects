using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(';');
            List<Person> people = new List<Person>();
            foreach (var personStr in input1)
            {
                string[] personArgs = personStr.Split('=');
                string personName = personArgs[0];
                decimal personMoney = decimal.Parse(personArgs[1]);

                Person person = new Person(personName, personMoney);
                people.Add(person);
            }
            string[] input2 = Console.ReadLine().Split(';');

            List<Product> products = new List<Product>();
            foreach (var productStr in input2)
            {
                string[] productArgs = productStr.Split('=', StringSplitOptions.RemoveEmptyEntries);
                
                string productName = productArgs[0];
                decimal productPrice = decimal.Parse(productArgs[1]);

                Product product = new Product(productName, productPrice);
                products.Add(product);
            }


            string purchase = Console.ReadLine();
            while (purchase != "END")
            {
                string[] splitted = purchase.Split();
                Person person = people.FirstOrDefault(x => x.Name == splitted[0]);
                Product product = products.FirstOrDefault(x => x.ProductName == splitted[1]);

                if (person != null && product != null)
                {
                string result = person.BuyProduct(product);
                    Console.WriteLine(result);

                }
                purchase = Console.ReadLine();
            }
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
