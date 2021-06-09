using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetSoreModels
{
   public class ClientProduct
    {
        [Required]
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }
        public virtual Client Client { get; set; }
        [Required]
        [ForeignKey(nameof(Products))]
        public string ProductId { get; set; }
        public virtual Products products { get; set; }
        [Range(1, Int32.MaxValue)]
        public int  Quantity { get; set; }
        [Required]
        [ForeignKey(nameof(Order))]
        public string OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
