﻿using Driver.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.Models.ViewModels
{
    public class TruckDriverRequirementDetailsViewModel
    {
        public TruckDriverRequirement TruckDriverRequirement { get; set; }
        public string PageTitle { get; set; }
    }
}
