using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoDog.Models
{
    public class Pet
    {
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

            }
    }
}



