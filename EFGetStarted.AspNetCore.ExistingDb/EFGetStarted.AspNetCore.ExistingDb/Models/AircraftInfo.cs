using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class AircraftInfo
    {
        public int ReportItemId { get; set; }
        public string AircraftFlag { get; set; }
        public string MajorComponentsMissing { get; set; }
        public string EngineMissing { get; set; }
        public string ElectricalProblem { get; set; }
        public string DataplateAvailable { get; set; }
        public string HistoricalDataRecords { get; set; }
        public string Certified { get; set; }
        public string FaaStandard { get; set; }
        public string UsedNonFlight { get; set; }
        public string UsedGroundTraining { get; set; }
        public string UsedStaticDisplay { get; set; }
        public string UsedDisassembAssemb { get; set; }
        public string UsedRepeatedBurning { get; set; }
        public string UsedMilitaryAcOnly { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
