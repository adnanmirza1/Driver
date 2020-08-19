using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.DbModels
{
    public class TruckDriverRequirement
    {
        [Key]
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string ContactPerson { get; set; }

        public string LicenseNo { get; set; }

        public int Mobile { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

    }
}
