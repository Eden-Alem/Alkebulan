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

namespace Datien.Controllers
{
    public class EntityRecordItem 
        {
            public string Name {get; set;}
            public int Count {get; set;}
        }
    public class HomeController : Controller
    {
        

        private readonly ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public async Task<IActionResult> EducationIndex()
        {
            return View();
        }

        public async Task<IActionResult> HealthIndex()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            return View();
        }

        public async Task<IActionResult> Statistics()
        {
            var entities = _context.EducationInstitution
                   .Select(g => g.InstitutionName).Distinct().ToList();
            return View(entities);
        }

        public ActionResult GetEducationData()
        {
            var query = _context.EducationInstitution
                   .GroupBy(p => p.InstitutionName)
                   .Select(g => new { name = g.Key, averageGraduates = g.Sum(w => w.AnnualAverageGraduates), teachingStaff = g.Sum(w => w.TeachingStaff), students = g.Sum(w => w.Students) }).ToList();
            return Json(query);
        }
        public ActionResult GetHealthData()
        {
            var query = _context.HealthInstitution
                   .GroupBy(p => p.InstitutionName)
                   .Select(g => new { name = g.Key, averagePatients = g.Sum(w => w.DailyAveragePatients), healthCareSpecialists = g.Sum(w => w.HealthCareSpecialists), healthEquipments = g.Sum(w => w.HealthEquipments) }).ToList();
            return Json(query);
        }

        public async Task<IActionResult> EducationCountryData(string name)
        {
            var entities = _context.EducationInstitution
                   .Select(g => g.InstitutionName).Distinct().ToList();

            
            var entity = (from res in _context.EducationInstitution
                where res.InstitutionName == name
                select res).ToList();
                
            ViewBag.entity = (entity);

            ViewBag.name = JsonConvert.SerializeObject(name);
            return View(entities);
        }

        public ActionResult GetEducationCountryData(string name)
        {
            var result = from res in _context.EducationInstitution
                where res.InstitutionName == name
                select new { name = res.FullName, averageGraduates= res.AnnualAverageGraduates, teachingStaff = res.TeachingStaff, students = res.Students };
            return Json(result);
        }


        public async Task<IActionResult> HealthCountryData(string name)
        {
            var entities = _context.HealthInstitution
                   .Select(g => g.InstitutionName).Distinct().ToList();

            
            var entity = (from res in _context.HealthInstitution
                where res.InstitutionName == name
                select res).ToList();
                
            ViewBag.entity = (entity);

            ViewBag.name = JsonConvert.SerializeObject(name);
            return View(entities);
        }

        public ActionResult GetHealthCountryData(string name)
        {
            var result = from res in _context.HealthInstitution
                where res.InstitutionName == name
                select new { name = res.FullName, averagePatients= res.DailyAveragePatients, healthCareSpecialists = res.HealthCareSpecialists, healthEquipments = res.HealthEquipments };
            return Json(result);
        }
        public ActionResult EducationStatistics()
        {
            var entities = _context.EducationInstitution
                   .Select(g => g.InstitutionName).Distinct().ToList();
            return View(entities);
        }

        public ActionResult HealthStatistics()
        {
            var entities = _context.HealthInstitution
                   .Select(g => g.InstitutionName).Distinct().ToList();
            return View(entities);
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
