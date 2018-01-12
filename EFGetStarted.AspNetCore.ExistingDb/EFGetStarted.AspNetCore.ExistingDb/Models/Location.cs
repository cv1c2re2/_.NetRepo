using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PocFName { get; set; }
        public string PocLName { get; set; }
        public string PocTelephone { get; set; }
        public string PocFax { get; set; }
        public string PocEmail { get; set; }
        public string AccPropOfficer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string PocTelephoneExt { get; set; }
        public string LocationCode { get; set; }
        public string RegionInd { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
