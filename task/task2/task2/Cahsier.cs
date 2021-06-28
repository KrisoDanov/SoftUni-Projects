using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Cahsier
    {

        public string WriteTheOrder(FinalOrder finalOrder)
        {
            StringBuilder sb = new StringBuilder();
            decimal totalPrice = 0;
            foreach (var item in finalOrder.Products)
            {
                sb.AppendLine(item.Name + " " + item.Brand);
                sb.AppendLine(item.Price.ToString());
                totalPrice += item.Price;
                // < name > < brand >
                //< quantity > x < price per product> = < total price without discount >
            }

            sb.AppendLine("------------------");
            sb.AppendLine("Total Price:" + totalPrice.ToString());

            return sb.ToString().TrimEnd();

            
        }
    }
}
