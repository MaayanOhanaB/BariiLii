using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BariiLii.Models
{
    public class Doctor
    {
        //Avoiding automatic numbering
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MinLengthAttribute(9)]
        [MaxLengthAttribute(9)]
        [Key]
        [Display(Name = "Doctor Id")]
        public string DId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Display(Name = "Availability")]
        //Displays just the time
        [DataType(DataType.Time)]
        public DateTime Availability { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Previous Exprience")]
        public int PreviousExprience { get; set; }

        public ICollection<AppointmentSystem> Appointments { get; set; }
    }
}
