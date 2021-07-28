using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Datien.Models;
using System.Web;
using System.Web.Mvc;
using Datien.Data.CAInterface;
using Datien.Data.CAClass;
using Datien.Data;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace Datien.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> EducationIndex()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EducationIndex([Bind("EducationID,CountryName,InstitutionName,LegalCertificate,TeachingStaff,Students,AnnualAverageGraduates,Latitude=4.9,Longitude=4.9")] EducationInstitution educationInstitution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(educationInstitution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EducationIndex));
            }
            return View(educationInstitution);
        }

        public async Task<IActionResult> HealthIndex()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HealthIndex([Bind("HealthID,CountryName,InstitutionName,LegalCertificate,HealthCareSpecialists,HealthEquipments,DailyAveragePatients,Latitude=4.9,Longitude=4.9")] HealthInstitution healthInstitution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(healthInstitution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(healthInstitution);
        }

        public async Task<IActionResult> About()
        {
            return View();
        }

        public async Task<IActionResult> AboutUs()
        {
            return View();
        }

        public async Task<IActionResult> Statistics()
        {
            var entities = _context.EducationInstitution
                   .Select(g => g.CountryName).Distinct().ToList();
            return View(entities);
        }

        public ActionResult GetEducationData()
        {
            var query = _context.EducationInstitution
                   .GroupBy(p => p.CountryName)
                   .Select(g => new { name = g.Key, averageGraduates = g.Sum(w => w.AnnualAverageGraduates), teachingStaff = g.Sum(w => w.TeachingStaff), students = g.Sum(w => w.Students) }).ToList();
            return Json(query);
        }
        public ActionResult GetHealthData()
        {
            var query = _context.HealthInstitution
                   .GroupBy(p => p.CountryName)
                   .Select(g => new { name = g.Key, averagePatients = g.Sum(w => w.DailyAveragePatients), healthCareSpecialists = g.Sum(w => w.HealthCareSpecialists), healthEquipments = g.Sum(w => w.HealthEquipments) }).ToList();
            return Json(query);
        }

        public async Task<IActionResult> EducationCountryData(string name)
        {
            var entities = _context.EducationInstitution
                   .Select(g => g.CountryName).Distinct().ToList();

            
            var entity = (from res in _context.EducationInstitution
                where res.CountryName == name
                select res).ToList();
                
            ViewBag.entity = (entity);

            ViewBag.name = JsonConvert.SerializeObject(name);
            return View(entities);
        }

        public ActionResult GetEducationCountryData(string name)
        {
            var result = from res in _context.EducationInstitution
                where res.CountryName == name
                select new { name = res.InstitutionName, averageGraduates= res.AnnualAverageGraduates, teachingStaff = res.TeachingStaff, students = res.Students };
            return Json(result);
        }


        public async Task<IActionResult> HealthCountryData(string name)
        {
            var entities = _context.HealthInstitution
                   .Select(g => g.CountryName).Distinct().ToList();

            
            var entity = (from res in _context.HealthInstitution
                where res.CountryName == name
                select res).ToList();
                
            ViewBag.entity = (entity);

            ViewBag.name = JsonConvert.SerializeObject(name);
            return View(entities);
        }

        public ActionResult GetHealthCountryData(string name)
        {
            var result = from res in _context.HealthInstitution
                where res.CountryName == name
                select new { name = res.InstitutionName, averagePatients= res.DailyAveragePatients, healthCareSpecialists = res.HealthCareSpecialists, healthEquipments = res.HealthEquipments };
            return Json(result);
        }
        public ActionResult EducationStatistics()
        {
            var entities = _context.EducationInstitution
                   .Select(g => g.CountryName).Distinct().ToList();
            return View(entities);
        }

        public ActionResult HealthStatistics()
        {
            var entities = _context.HealthInstitution
                   .Select(g => g.CountryName).Distinct().ToList();
            return View(entities);
        }

        public ActionResult LoginUser()
        {
            if (TempData["UserEmail"] != null)  return RedirectToAction(nameof(Statistics));
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(string email, string password)
        {            
            try
            {
                var user = _context.User.FirstOrDefault(u => u.UserEmail == email);
                if (user != null)
                {
                    Dictionary<string, string> c = new Dictionary<string, string>();
                    TempData["email"] = user.UserEmail;
                    TempData["password"] = user.Password;  
                    return RedirectToAction(nameof(Statistics));                  
                }
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
                throw;
            }
        }

        public ActionResult Logout()
        {
            TempData["email"] = null;
            TempData["password"] = null;
            
            return RedirectToAction(nameof(LoginUser));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterUser([Bind("FirstName,LastName,Username,UserEmail,Password,ConfirmPassword")] User User)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(User);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Statistics));
            }
            return RedirectToAction(nameof(LoginUser));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
