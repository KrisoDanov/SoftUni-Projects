using PetSore.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetSoreModels
{
    public class Client
    {
        public Client()
        {
            Id = Guid.NewGuid().ToString();
            PetsBuyed = new HashSet<Pet>();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        [MinLength(GlobalConstants.UsernameMinLenght)]
        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        [MinLength(GlobalConstants.EmailMinLenght)]
        public string Email { get; set; }
        [Required]
        [MinLength(GlobalConstants.ClientMinLenght)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(GlobalConstants.ClientMinLenght)]
        public string LastName { get; set; }
        public virtual ICollection<Pet> PetsBuyed { get; set; }
    }
}
