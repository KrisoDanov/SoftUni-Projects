using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Food : Product
    {

        private DateTime expirationDate;

        public Food(string name, string brand, decimal price, DateTime expirationDate) : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; } 
            set {

                if (DateTime.UtcNow.Date == expirationDate)
                {
                    Price = Price * 0.5M;
                }
                if ((DateTime.UtcNow - expirationDate).TotalDays == 5)
                {
                    Price = Price * 0.9M;
                }
                expirationDate = value; 
            }  
        }
    }
}
