using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datien.Models
{
    public class HealthInstitution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HealthID { get; set; }

        [Display(Name = "Institution Name")]
        [StringLength(300)]
        [Required(ErrorMessage = "{0} is required ")]
        public string InstitutionName { get; set; }

        [Display(Name = "Country")]
        [StringLength(300)]
        [Required(ErrorMessage = "{0} is required ")]
        public string CountryName { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(500)]
        // [Required(ErrorMessage = "{0} is required ")]
        public string FullName { get; set; }
        

        [Display(Name = "Legal Certificate")]
        // [Required(ErrorMessage = "{0} is required ")]
        public string LegalCertificate { get; set; }

        [Display(Name = "Health Care Specialists")]
        public int HealthCareSpecialists { get; set; }

        [Display(Name = "Health Equipments")]
        public int HealthEquipments { get; set; }
        
        [Display(Name = "Daily Average Patients")]
        public int DailyAveragePatients { get; set; }

        [Display(Name = "Latitude")]
        public decimal Latitude { get; set; }

        [Display(Name = "Longitude")]
        public decimal Longitude { get; set; }
    
    }
}
