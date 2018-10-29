using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatientTrac.Models;

namespace PatientTrac.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PatientTrac.Models.Doctor> Doctor { get; set; }
        public DbSet<PatientTrac.Models.Medication> Medication { get; set; }
    }
}
