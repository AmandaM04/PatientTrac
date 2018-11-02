using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrac.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public Medication Medications { get; set; }

        [Display(Name = "Current Medications")]
        public virtual ICollection<PatientMedication> CurrentMedications { get; set; }

        public virtual ICollection<DoctorPatient> DoctorPatients { get; set; }

        [Display(Name = "Patient Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
