using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.ViewModels
{
    public class TruckDriverRequirementEditViewModel : TruckDriverRequirementCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
