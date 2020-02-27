using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SP749415_MIS4200.Models
{
    public class Vets
    {
        [Key]
        public int vetId { get; set; }

        [Display(Name = "Vet's First Name")]
        [Required(ErrorMessage = "Vet first name is required.")]
        [StringLength(20)]
        public string vetFirstName { get; set; }

        [Display(Name = "Vet's Last Name")]
        [Required(ErrorMessage = "Vet last name is required.")]
        [StringLength(20)]
        public string vetLastName { get; set; }

        public ICollection<Appointments> Appointments { get; set; }
    }
}