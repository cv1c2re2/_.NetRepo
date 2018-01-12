﻿using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class NoOfCylinders
    {
        public NoOfCylinders()
        {
            VehicleInfo = new HashSet<VehicleInfo>();
        }

        public int NoOfCylindersId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public string Deleteflag { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public ICollection<VehicleInfo> VehicleInfo { get; set; }
    }
}
