using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datien.Models
{
    public class EducationInstitution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EducationID { get; set; }

        [Display(Name = "Institution Name")]
        [StringLength(300)]
        [Required(ErrorMessage = "{0} is required ")]
        public string InstitutionName { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(500)]
        [Required(ErrorMessage = "{0} is required ")]
        public string FullName { get; set; }

        [Display(Name = "Legal Certificate")]
        // [Required(ErrorMessage = "{0} is required ")]
        public string LegalCertificate { get; set; }

        [Display(Name = "TeachingStaff")]
        public string TeachingStaff { get; set; }

        [Display(Name = "Students")]
        public string Students { get; set; }
        
        [Display(Name = "Annual Average Graduates")]
        public string AnnualAverageGraduates { get; set; }

        [Display(Name = "Latitude")]
        public decimal Latitude { get; set; }

        [Display(Name = "Longitude")]
        public decimal Longitude { get; set; }
    }
}
