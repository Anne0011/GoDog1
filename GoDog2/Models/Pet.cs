using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoDog2.Models
{
    public class Pet
    {
        private List<ApplicationUser> pets;

        [Key]
        public int PetId { get; set; }

        public string picture { get; set; }
        public string petName { get; set; }
        public string petBreed { get; set; }
        public string petSize { get; set; }
        public int petWeight { get; set; }
        public int petAge { get; set; }

        public virtual ICollection<PetLog> PetLog { get; set; }

        public Pet()
        {
            PetLog = new List<PetLog>();
            pets = new List<ApplicationUser>();

        }
    }
}