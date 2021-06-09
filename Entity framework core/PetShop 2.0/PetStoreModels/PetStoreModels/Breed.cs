using PetSore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetSoreModels
{
    public class Breed
    {
        public Breed()
        {
            Pets = new HashSet<Pet>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(GlobalConstants.BreedNameMinLenght)]
        public string Name { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
