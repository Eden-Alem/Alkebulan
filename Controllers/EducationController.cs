using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Datien.Data;
using Datien.Models;

namespace Datien.Controllers
{
    public class EducationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EducationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Education
        public async Task<IActionResult> Index()
        {
            return View(await _context.EducationInstitution.ToListAsync());
        }

        // GET: Education/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationInstitution = await _context.EducationInstitution
                .FirstOrDefaultAsync(m => m.EducationID == id);
            if (educationInstitution == null)
            {
                return NotFound();
            }

            return View(educationInstitution);
        }

        // GET: Education/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Education/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EducationID,CountryName,InstitutionName,LegalCertificate,TeachingStaff,Students,AnnualAverageGraduates,Latitude,Longitude")] EducationInstitution educationInstitution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(educationInstitution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details));
            }
            return View(educationInstitution);
        }

        // GET: Education/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationInstitution = await _context.EducationInstitution.FindAsync(id);
            if (educationInstitution == null)
            {
                return NotFound();
            }
            return View(educationInstitution);
        }

        // POST: Education/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EducationID,CountryName,InstitutionName,LegalCertificate,TeachingStaff,Students,AnnualAverageGraduates,Latitude,Longitude")] EducationInstitution educationInstitution)
        {
            if (id != educationInstitution.EducationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(educationInstitution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EducationInstitutionExists(educationInstitution.EducationID))
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
            return View(educationInstitution);
        }

        // GET: Education/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var educationInstitution = await _context.EducationInstitution
                .FirstOrDefaultAsync(m => m.EducationID == id);
            if (educationInstitution == null)
            {
                return NotFound();
            }

            return View(educationInstitution);
        }

        // POST: Education/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var educationInstitution = await _context.EducationInstitution.FindAsync(id);
            _context.EducationInstitution.Remove(educationInstitution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EducationInstitutionExists(int id)
        {
            return _context.EducationInstitution.Any(e => e.EducationID == id);
        }
    }
}
