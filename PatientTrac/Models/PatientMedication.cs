using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrac.Models
{
    public class PatientMedication
    {
        [Key]
        public int PatientMedicationId { get; set; }

        [Required]
        public bool CurrentlyTaking { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime StopDate { get; set; }

        [Required]
        public int Dosage { get; set; }

        [Required]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        [Required]
        public int MedicationId { get; set; }

        public Medication Medication { get; set; }
    }
}
