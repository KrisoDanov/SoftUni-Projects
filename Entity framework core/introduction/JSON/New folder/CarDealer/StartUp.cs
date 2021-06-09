using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext db = new CarDealerContext();

            if (!Directory.Exists("../../../Datasets/Results"))
            {
                Directory.CreateDirectory("../../../Datasets/Results");
            }
            string fileRead = "../../../Datasets/suppliers.json";

            ImportSuppliers(db, fileRead);

        }
        private static void CreateDatabase(CarDealerContext db)
        {
            db.Database.EnsureCreated();
            Console.WriteLine("Created");
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }
    }
}