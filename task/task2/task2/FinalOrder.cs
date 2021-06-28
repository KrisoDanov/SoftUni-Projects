using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class FinalOrder
    {

        public FinalOrder()
        {
            Products = new HashSet<Product>();
        }
        public virtual ICollection<Product> Products { get; set; }
    }
}
