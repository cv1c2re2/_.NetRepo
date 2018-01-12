using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ReportItemHistory
    {
        public int ReportItemHistoryId { get; set; }
        public int ReportItemId { get; set; }
        public string ReportNumber { get; set; }
        public int? LocationId { get; set; }
        public string ItemName { get; set; }
        public string Niin { get; set; }
        public string ItemDescription { get; set; }
        public string Model { get; set; }
        public string PartNo { get; set; }
        public int? Qty { get; set; }
        public double? UnitCost { get; set; }
        public string PicturesAvailable { get; set; }
        public string ProceedsRetention { get; set; }
        public double? AgencyLocationCode { get; set; }
        public string SpecialDescription { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Completed { get; set; }
        public string ReqScrapPickup { get; set; }
        public string CertDestruction { get; set; }
        public string ReportCancelled { get; set; }
        public string GsaComments { get; set; }
        public string EngrDeision { get; set; }
        public string EngrComments { get; set; }
        public DateTime? EngrDecidedDate { get; set; }
        public DateTime? ToEngDate { get; set; }
        public string MngtDecision { get; set; }
        public string ManagerComments { get; set; }
        public DateTime? MngtDecidedDate { get; set; }
        public string WarehouseComments { get; set; }
        public string AccessLevel { get; set; }
        public DateTime? SurplusReleaseDate { get; set; }
        public DateTime? InternalReleaseDate { get; set; }
        public string DropInternalFlag { get; set; }
        public DateTime? ExcessRelDate { get; set; }
        public string FscapCode { get; set; }
        public string ReportCode { get; set; }
        public string Make { get; set; }
        public DateTime? AcquisitionDate { get; set; }
        public DateTime? ManufacturedDate { get; set; }
        public string Manufacturer { get; set; }
        public string SpecialDesCode { get; set; }
        public string Agybur { get; set; }
        public string AgyControlNo { get; set; }
        public string AppropCode { get; set; }
        public string ClRefNo { get; set; }
        public int? ClLineItemNo { get; set; }
        public string CountryCode { get; set; }
        public string Drmo { get; set; }
        public double? FairMarketValue { get; set; }
        public string HazmatCode { get; set; }
        public string OverseasInd { get; set; }
        public string PlantClCaseNo { get; set; }
        public string ReimbReqd { get; set; }
        public string Vessels50FeetOver { get; set; }
        public string ShipName { get; set; }
        public string GsaRegionCode { get; set; }
        public string GsaSubmitRespNo { get; set; }
        public string GsaSubmitTimeElap { get; set; }
        public string GsaSubmitMsg { get; set; }
        public string PropLocAddr1 { get; set; }
        public string PropLocAddr2 { get; set; }
        public string PropLocAddr3 { get; set; }
        public string PropLocCity { get; set; }
        public string PropLocState { get; set; }
        public string PropLocZip { get; set; }
        public string Exchsale { get; set; }
        public string Cntrinvcd { get; set; }
        public string FiscalYear { get; set; }
        public int? ReportAgencyId { get; set; }
        public int? FederalAssetSalesId { get; set; }
        public int? ReimbursementTypeId { get; set; }
        public int? FscId { get; set; }
        public int? SupplyConditionId { get; set; }
        public int? DisposalConditionId { get; set; }
        public int? DemilitarizationId { get; set; }
        public int? UnitOfIssueId { get; set; }
        public int? StatusCodeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public int? MngtDecisionId { get; set; }
    }
}
