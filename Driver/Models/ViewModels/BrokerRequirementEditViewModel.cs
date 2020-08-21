using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.ViewModels
{
    public class BrokerRequirementEditViewModel : BrokerRequirementCreateViewModel
    {
        [Key]
        public int Id { get; set; }
    }
}
