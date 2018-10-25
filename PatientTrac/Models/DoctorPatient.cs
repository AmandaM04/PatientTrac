using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrac.Models
{
    public class DoctorPatient
    {
        [Key]
        public int DoctorPatientId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        [Required]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }
    }
}
