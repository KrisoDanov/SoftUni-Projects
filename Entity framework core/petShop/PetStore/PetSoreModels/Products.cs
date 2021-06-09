using PetSore.Common;
using PetSoreModels.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetSoreModels
{
    public class Products
    {
        public Products()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MinLength(GlobalConstants.ProductMinLenght)]
        public string Name { get; set; }

        public ProductType productType{ get; set; }
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
