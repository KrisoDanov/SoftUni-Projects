using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage
{
    public interface IPerosn
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetName();
        
    }
}
