using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class CflInfo
    {
        public int ReportItemId { get; set; }
        public string CflCode { get; set; }
        public string CflEligibleOrgn { get; set; }
        public string CflPayShipping { get; set; }
        public string CflEquipType { get; set; }
        public string CflProcessor { get; set; }
        public int? HardwareTypeId { get; set; }
        public int? RamId { get; set; }
        public int? ProcessorSpeedId { get; set; }
        public int? HardDiskSizeId { get; set; }
        public int? HardDiskStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
