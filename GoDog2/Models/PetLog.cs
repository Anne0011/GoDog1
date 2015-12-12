using System;
using System.ComponentModel.DataAnnotations;

namespace GoDog2.Models
{
    public enum Activity
    {
        Walking, Jogging, Playing
    }

    public class PetLog
    {
        [Key]
        public int PetLogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Activity { get; set; }
        internal int duration { get; set; }

        // Navigaton Properties
        public virtual Pet Pet { get; set; }
        

    }
 
}