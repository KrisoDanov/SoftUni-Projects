using PetSore.Common;
using PetSoreModels.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetSoreModels
{
   public class Pet
    {
        public Pet()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MinLength(GlobalConstants.PetMinLenght)]
        public string Name{ get; set; }
        public Gender Gender { get; set; }
        [Range(0, 200)]
        public byte Age { get; set; }
        public bool IsSold { get; set; }
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        [ForeignKey(nameof(Breed))]
        public int BreedId { get; set; }
        public virtual Breed Breed { get; set; }
        [ForeignKey(nameof(Client))]
        public string ClientID { get; set; }
        public virtual Client Client { get; set; }

    }
}
