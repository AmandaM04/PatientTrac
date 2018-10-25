using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrac.Models
{
    public class Medication
    {
        [Key]
        public int MedicationId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }
    }
}
