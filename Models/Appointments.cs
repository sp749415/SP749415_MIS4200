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
        public string description { get; set; }
        public int cost { get; set; }
        public DateTime appointmentDateTime { get; set; }

        // the next two properties link the appointment to the pet
        public int petID { get; set; }
        public virtual Pets Pets { get; set; }
        // the next two properties link the appointment to the vet
        public int vetID { get; set; }
        public virtual Vets Vet { get; set; }

    }
}