using PetSore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PetSoreModels
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid().ToString();
            ClientProducts = new HashSet<ClientProduct>();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MinLength(GlobalConstants.TownNameMinLenght)]
        public string Town { get; set; }
        [Required]
        [MinLength(GlobalConstants.AdressMinLenght)]
        public string Address { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<ClientProduct> ClientProducts { get; set; }
        public decimal TotalPrice => ClientProducts.Sum(cp => cp.products.Price * cp.Quantity);
    }
}
