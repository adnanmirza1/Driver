using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.DbModels
{
    public class DriverBasic
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "FirstName")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last name")]
        [Display(Name = "LastName")]
        [StringLength(100)]
        public string LastName { get; set; }

        public int EmiratesId { get; set; }

        public int WhatsappNo { get; set; }

        public int MobileNo { get; set; }

        public int InternationalNo { get; set; }

        public string Language { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        public string Picture { get; set; }
    }
}
