﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage
{
    public interface IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public string GetName();
    }
}
