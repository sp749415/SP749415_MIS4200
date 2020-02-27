using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SP749415_MIS4200.Models
{
    public class Pets
    {
        [Key]
        public int petID { get; set; }

        [Display (Name = "Pet Name")]
        [Required(ErrorMessage ="Pet name is required.")]
        [StringLength(20)]
        public string petName { get; set; }

        [Display(Name = "Pet Type")]
        [Required(ErrorMessage = "Type of pet is required.")]
        [StringLength(20)]
        public string petSpecies { get; set; }

        [Display(Name = "Pet Breed")]
        [Required(ErrorMessage = "Pet Breed is required.")]
        [StringLength(20)]
        public string petBreed { get; set; }

        [Display(Name = "Pet Age")]
        [Required]
        public int petAge { get; set; }

        public ICollection<Appointments> Appointments { get; set; }

        

        
       
    }
}