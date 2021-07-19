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
    public class HealthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HealthController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Health
        public async Task<IActionResult> Index()
        {
            return View(await _context.HealthInstitution.ToListAsync());
        }

        // GET: Health/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthInstitution = await _context.HealthInstitution
                .FirstOrDefaultAsync(m => m.HealthID == id);
            if (healthInstitution == null)
            {
                return NotFound();
            }

            return View(healthInstitution);
        }

        // GET: Health/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Health/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HealthID,InstitutionName,FullName,LegalCertificate,HealthCareSpecialists,HealthEquipments,DailyAveragePatients,Latitude,Longitude")] HealthInstitution healthInstitution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthInstitution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(healthInstitution);
        }

        // GET: Health/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthInstitution = await _context.HealthInstitution.FindAsync(id);
            if (healthInstitution == null)
            {
                return NotFound();
            }
            return View(healthInstitution);
        }

        // POST: Health/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HealthID,InstitutionName,FullName,LegalCertificate,HealthCareSpecialists,HealthEquipments,DailyAveragePatients,Latitude,Longitude")] HealthInstitution healthInstitution)
        {
            if (id != healthInstitution.HealthID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(healthInstitution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthInstitutionExists(healthInstitution.HealthID))
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
            return View(healthInstitution);
        }

        // GET: Health/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthInstitution = await _context.HealthInstitution
                .FirstOrDefaultAsync(m => m.HealthID == id);
            if (healthInstitution == null)
            {
                return NotFound();
            }

            return View(healthInstitution);
        }

        // POST: Health/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var healthInstitution = await _context.HealthInstitution.FindAsync(id);
            _context.HealthInstitution.Remove(healthInstitution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthInstitutionExists(int id)
        {
            return _context.HealthInstitution.Any(e => e.HealthID == id);
        }
    }
}
