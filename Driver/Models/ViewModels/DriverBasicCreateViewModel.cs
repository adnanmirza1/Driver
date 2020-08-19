using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.ViewModels
{
    public class DriverBasicCreateViewModel
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
        public IFormFile Picture { get; set; }

        public string Nationality { get; set; }

        public string DateOfBirth { get; set; }

        public string DateOfJoining { get; set; }

        public string PassportNo { get; set; }

        public string PassportExpiryDate { get; set; }

        public string VisaExpiry { get; set; }

        public string ResidenceCountry { get; set; }

        public string CityName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string DriverType { get; set; }

        public string Company { get; set; }
    }
}
