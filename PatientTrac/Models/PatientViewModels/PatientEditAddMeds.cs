﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
            MedicationId = context.Medication.Select(medication =>
            new SelectListItem { Text = medication.Name, Value = medication.MedicationId.ToString() }).ToList();

        }

        public int PatientId { get; set; }
 
        public bool CurrentlyTaking { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? StopDate { get; set; }

        public int Dosage { get; set; }

        public List<SelectListItem> MedicationId { get; set; }
    }
}
