using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ProductShopContext db = new ProductShopContext();

            string inputJson = GetCategoriesByProductsCount(db);
            if (!Directory.Exists("../../../Datasets/Results"))
            {
                Directory.CreateDirectory("../../../Datasets/Results");
            }
            File.WriteAllText("../../../Datasets/Results/categories-by-products.json", inputJson);
        }

        private static void CreateDatabase(ProductShopContext db)
        {
            db.Database.EnsureCreated();
            Console.WriteLine("Created");
        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            List<User> users = JsonConvert.DeserializeObject<List<User>>(inputJson);

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";

        }


        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(inputJson);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";
        }
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(inputJson);

            context.Categories.AddRange(categories);

            context.SaveChanges();

            return $"Successfully imported {categories.Count}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            List<CategoryProduct> categoryproducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(inputJson);

            context.CategoryProducts.AddRange(categoryproducts);
            context.SaveChanges();
            return $"Successfully imported {categoryproducts.Count}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.
                Products
                .Where(x => x.Price > 500 && x.Price < 1000)
                .OrderBy(x => x.Price)
                .Select(x => new
                {
                    name = x.Name,
                    price = x.Price,
                    seller = x.Seller.FirstName + ' ' + x.Seller.LastName
                })
                .ToArray();

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            return json;
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context
                .Users
                .Where(x => x.ProductsSold
                .Any(k => k.Buyer != null))
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    soldProducts = x.ProductsSold
                .Where(u => u.Buyer != null)
                .Select(y => new
                {
                    name = y.Name,
                    price = y.Price,
                    buyerFirstName = y.Buyer.FirstName,
                    buyerLastName = y.Buyer.LastName

                })
                .ToArray()
                })
                .ToArray();

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            
            return json;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var products = context
                .Categories
                .Select(x => new
                {
                    category = x.Name,
                    productsCount = x.CategoryProducts.Count(),
                    averagePrice = x.CategoryProducts
                    .Average(cp => cp.Product.Price)
                    .ToString("f2"),
                    totalRevenue = x.CategoryProducts
                    .Sum(c => c.Product.Price)
                    .ToString("f2")
                })
                 .OrderByDescending(x => x.productsCount)
                 .ToArray();

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            return json;
        }
    }
}