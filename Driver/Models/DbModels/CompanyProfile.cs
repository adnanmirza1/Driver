using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.DbModels
{
    public class CompanyProfile
    {
        [Key]
        public int Id { get; set; }

        public string DriverType { get; set; }

        public string Company { get; set; }
    }
}
