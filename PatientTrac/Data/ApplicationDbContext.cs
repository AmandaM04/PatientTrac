using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
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
        public DbSet<PatientTrac.Models.DoctorPatient> DoctorPatients { get; set; }
        public DbSet<PatientTrac.Models.Medication> Medication { get; set; }
        public DbSet<PatientTrac.Models.Patient> Patient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Doctor user = new Doctor
            {
                FirstName = "Jill",
                LastName = "Scott",
                Facility = "Vanderbilt",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<Doctor>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin123!");
            modelBuilder.Entity<Doctor>().HasData(user);

            modelBuilder.Entity<Patient>().HasData(
                new Patient()
                {
                    PatientId = 1,
                    FirstName = "Amanda",
                    LastName = "Mitchell",
                    StreetAddress = "123 Book Street",
                    PhoneNumber = "615-123-4567",
                    Age = 32,
                    Sex = "Female"
                },
                new Patient()
                {
                    PatientId = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    StreetAddress = "789 Yellow Brick Rd",
                    PhoneNumber = "931-380-9843",
                    Age = 50,
                    Sex = "Male"
                }
            );

            modelBuilder.Entity<Medication>().HasData(
                new Medication()
                {
                    MedicationId = 1,
                    Name = "Ofloxacin",
                    Type = "Antibiotics"
                },
                new Medication()
                {
                    MedicationId = 2,
                    Name = "Oxycodone",
                    Type = "Analgesics"
                }
            );

            modelBuilder.Entity<DoctorPatient>().HasData(
                new DoctorPatient()
                {
                    DoctorPatientId = 1,
                    DoctorId = user.Id,
                    PatientId = 1
                }
            );
        }
    }
}
