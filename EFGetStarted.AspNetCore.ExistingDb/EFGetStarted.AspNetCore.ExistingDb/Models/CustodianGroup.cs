using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class CustodianGroup
    {
        public int CustodianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NotifySale { get; set; }
        public int ReportItemId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }

        public ReportItem ReportItem { get; set; }
    }
}
