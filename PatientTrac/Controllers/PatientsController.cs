using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PatientTrac.Data;
using PatientTrac.Models;
using PatientTrac.Models.PatientViewModels;

namespace PatientTrac.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Stores private reference to Identity Framework user manager
        private readonly UserManager<IdentityUser> _userManager;

        public PatientsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // This task retrieves the currently authenticated user
        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var applicationDbContext = _context.DoctorPatients
                    .Include("Doctor")
                    .Include("Patient")
                    .Where(dp => dp.DoctorId == user.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // Search: Patients
        public async Task<IActionResult> Search(string searchQuery)
        {
            List<Patient> searchResults = new List<Patient>();
            searchResults = await _context.Patient.Where(p => p.FullName.Contains(searchQuery)).ToListAsync();
            return View(searchResults);
        }

        // GET: Patients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                //joining 2 tables on the patientmedication join table
                .Include("CurrentMedications.Medication")
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public async Task <IActionResult> Create()
        {
            // Get the current user
            var user = await GetCurrentUserAsync();

            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientId,FirstName,LastName,StreetAddress,PhoneNumber,Age,Sex")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                // Get the current user
                var user = await GetCurrentUserAsync();

                patient.IdentityUser = user;

                _context.Add(patient);
                DoctorPatient newPatient = new DoctorPatient();
                newPatient.DoctorId = user.Id;
                newPatient.PatientId = patient.PatientId;
                _context.Add(newPatient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(patient);
        }

        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatientId,FirstName,LastName,StreetAddress,PhoneNumber,Age,Sex")] Patient patient)
        {
            if (id != patient.PatientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.PatientId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patients/AddMeds/5
        public ActionResult AddMeds(int id)
        {
         
            PatientEditAddMeds viewModel = new PatientEditAddMeds(_context);
            // this is to assign the fields in the viewmodel with the information inside the input fields
            viewModel.PatientId = id;
            viewModel.StartDate = DateTime.Now;
            //viewModel.StopDate = DateTime.Now;
            return View(viewModel);
        }

        // POST: Patients/AddMeds/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMeds(int id, PatientMedication patientmeds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientmeds);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PatientEditAddMeds viewModel = new PatientEditAddMeds(_context);
            return View(viewModel);
        }

        // GET: Patients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .FirstOrDefaultAsync(m => m.PatientId == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _context.Patient.FindAsync(id);
            _context.Patient.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(int id)
        {
            return _context.Patient.Any(e => e.PatientId == id);
        }
    }
}
