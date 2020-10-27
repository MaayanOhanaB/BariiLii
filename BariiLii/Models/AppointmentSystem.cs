using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BariiLii.Models
{
    public class AppointmentSystem
    {
        [Key]
        [Display(Name = "Type Of Pain")]
        public string TypeOfPain { get; set; }

        [Display(Name = "Medical Team Id")]
        public int DId { get; set; }

        [Display(Name = "Patient Id")]
        public int PatientId { get; set; }

        [Display(Name = "Availability Queues")]
        //Displays just the time
        [DataType(DataType.Time)]
        public DateTime AvailabilityQueues { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
