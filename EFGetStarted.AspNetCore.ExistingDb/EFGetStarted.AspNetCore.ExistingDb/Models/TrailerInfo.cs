using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class TrailerInfo
    {
        public int ReportItemId { get; set; }
        public string TypeSlideOut { get; set; }
        public string TypeAwning { get; set; }
        public int? NoAxles { get; set; }
        public int? NoBedrooms { get; set; }
        public int? NoBaths { get; set; }
        public int? WindZone { get; set; }
        public int? Length { get; set; }
        public string Barcode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public ReportItem ReportItem { get; set; }
    }
}
