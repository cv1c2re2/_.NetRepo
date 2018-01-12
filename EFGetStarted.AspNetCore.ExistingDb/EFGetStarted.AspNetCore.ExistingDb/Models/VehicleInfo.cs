using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class VehicleInfo
    {
        public int VehicleInfoId { get; set; }
        public string VehicleIdNumber { get; set; }
        public int? ModelYear { get; set; }
        public string EstMileage { get; set; }
        public int? NoCylinders { get; set; }
        public int? FuelTypeId { get; set; }
        public int? BodyStyleId { get; set; }
        public int? VehicleColorId { get; set; }
        public int? ColorGradientId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public int? NoOfCylindersId { get; set; }
        public string Transmission { get; set; }
        public string AgencyClass { get; set; }
        public string VehicleTag { get; set; }

        public BodyStyle BodyStyle { get; set; }
        public ColorGradient ColorGradient { get; set; }
        public FuelType FuelType { get; set; }
        public NoOfCylinders NoOfCylinders { get; set; }
        public VehicleColor VehicleColor { get; set; }
    }
}
