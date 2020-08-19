using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.DbModels
{
    public class DriverProfile
    {
        [Key]
        public int Id { get; set; }

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

        
    }
}
