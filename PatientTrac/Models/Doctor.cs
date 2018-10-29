using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrac.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        public string Facility { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        [Display(Name = "Doctor Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
