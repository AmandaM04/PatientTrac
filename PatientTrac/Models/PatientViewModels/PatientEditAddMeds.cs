using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatientTrac.Data;

namespace PatientTrac.Models.PatientViewModels
{
    public class PatientEditAddMeds
    {
        public PatientEditAddMeds(ApplicationDbContext context)
        {
            Medications = context.Medication.Select(medication =>
            new SelectListItem { Text = medication.Name, Value = medication.MedicationId.ToString() }).ToList();

        }

        public PatientMedication PatientMedications { get; set; }

        public List<SelectListItem> Medications { get; set; }
    }
}
