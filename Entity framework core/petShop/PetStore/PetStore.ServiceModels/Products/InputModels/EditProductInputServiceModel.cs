using PetSore.Common;
using PetSoreModels.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetStore.ServiceModels.Products.InputModels
{
   public class EditProductInputServiceModel
    {
        [Required]
        [MinLength(GlobalConstants.ProductMinLenght)]
        [MaxLength(30)]
        public string Name { get; set; }

        public string productType { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
    }
}
