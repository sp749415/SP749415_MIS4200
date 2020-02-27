using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SP749415_MIS4200.Models
{
    public class Appointments
    {
        [Key]
        public int appointmentID { get; set; }

        [Display(Name = "Description of the Appointment")]
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500)]
        public string description { get; set; }

        [Display(Name = "Cost")]
        [Required(ErrorMessage = "Cost is required.")]
        [DataType(DataType.Currency)]
        public int cost { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime appointmentDateTime { get; set; }

        // the next two properties link the appointment to the pet
        public int petID { get; set; }
        public virtual Pets Pets { get; set; }
        // the next two properties link the appointment to the vet
        public int vetID { get; set; }
        public virtual Vets Vet { get; set; }

    }
}