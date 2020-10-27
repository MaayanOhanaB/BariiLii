using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BariiLii.Models
{
    public enum Rate
    {
        A=1,B,C,D,E
    }

    public class Patient
    {
        //Avoiding automatic numbering
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MinLengthAttribute(9)]
        [MaxLengthAttribute(9)]
        [Key]
        [Display(Name = "Patient Id")]
        public string PatientId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Type Of Pain")]
        public string TypeOfPain { get; set; }

        [Display(Name = "Rate Your Doctor")]
        public Rate? DocRate { get; set; }

        public ICollection<AppointmentSystem> Appointments { get; set; }
    }
}
