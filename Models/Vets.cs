using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SP749415_MIS4200.Models
{
    public class Vets
    {
        [Key]
        public int vetId { get; set; }
        public string vetFirstName { get; set; }
        public string vetLastName { get; set; }

        public ICollection<Appointments> Appointments { get; set; }
    }
}