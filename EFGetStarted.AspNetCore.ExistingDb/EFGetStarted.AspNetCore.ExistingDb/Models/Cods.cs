using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Cods
    {
        public int CodId { get; set; }
        public int ReportItemId { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string ContentType { get; set; }
        public int? StatusCodeId { get; set; }
    }
}
