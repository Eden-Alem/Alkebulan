using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datien.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(300)]
        // [Required(ErrorMessage = "{0} is required ")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [StringLength(300)]
        // [Required(ErrorMessage = "{0} is required ")]
        public string LastName { get; set; }


        [Display(Name = "Username")]
        [StringLength(300)]
        // [Required(ErrorMessage = "{0} is required ")]
        public string Username { get; set; }

        [Display(Name = "User Email")]
        [StringLength(300)]
        [Required(ErrorMessage = "{0} is required ")]
        public string UserEmail { get; set; }

        [Display(Name = "Password")]
        [StringLength(300)]
        [Required(ErrorMessage = "{0} is required ")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [StringLength(300)]
        public string ConfirmPassword { get; set; }

    }
}
