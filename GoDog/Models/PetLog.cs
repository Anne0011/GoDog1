using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace GoDog.Models
{public enum Activity
    {
        Walking, Jogging, Playing
    }
    public class PetLog
    {
        public int PetLogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Activity { get; set; }
        internal int duration { get; set; }
        
        

        // Navigaton Properties
        public virtual Pet Pet { get; set; }

        
    }
}