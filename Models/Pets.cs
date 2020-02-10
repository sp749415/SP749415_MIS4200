using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SP749415_MIS4200.Models
{
    public class Pets
    {
        [Key]
        public int petID { get; set; }
        public string petName { get; set; }
        public string petSpecies { get; set; }
        public string petBreed { get; set; }
        public int petAge { get; set; }

        public ICollection<Appointments> Appointments { get; set; }

        

        
       
    }
}