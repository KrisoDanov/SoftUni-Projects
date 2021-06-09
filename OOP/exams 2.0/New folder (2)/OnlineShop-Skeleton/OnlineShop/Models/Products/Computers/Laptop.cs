﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public class Laptop : Computer
    {
        private const int laptopOveralPerfomance = 15;
        public Laptop(int id, string manufacturer, string model, decimal price) : base(id, manufacturer, model, price, laptopOveralPerfomance)
        {
        }
    }
}
