using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.ExistingDb.Models;

namespace EFGetStarted.AspNetCore.ExistingDb.Controllers
{
    public class ReportItemsController : Controller
    {
        private readonly EPPContext _context;

        public ReportItemsController(EPPContext context)
        {
            _context = context;
        }

        // GET: ReportItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportItem.ToListAsync());
        }

        // GET: ReportItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportItem = await _context.ReportItem
                .SingleOrDefaultAsync(m => m.ReportItemId == id);
            if (reportItem == null)
            {
                return NotFound();
            }

            return View(reportItem);
        }

        // GET: ReportItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportItemId,ReportNumber,LocationId,ItemName,Niin,ItemDescription,Model,PartNo,Qty,UnitCost,PicturesAvailable,ProceedsRetention,AgencyLocationCode,SpecialDescription,CompletedDate,Completed,ReqScrapPickup,CertDestruction,ReportCancelled,GsaComments,EngrDeision,EngrComments,EngrDecidedDate,ToEngDate,MngtDecision,ManagerComments,MngtDecidedDate,WarehouseComments,AccessLevel,SurplusReleaseDate,InternalReleaseDate,DropInternalFlag,ExcessRelDate,FscapCode,ReportCode,Make,AcquisitionDate,ManufacturedDate,Manufacturer,SpecialDesCode,Agybur,AgyControlNo,AppropCode,ClRefNo,ClLineItemNo,CountryCode,Drmo,FairMarketValue,HazmatCode,OverseasInd,PlantClCaseNo,ReimbReqd,Vessels50FeetOver,ShipName,GsaRegionCode,GsaSubmitRespNo,GsaSubmitTimeElap,GsaSubmitMsg,PropLocAddr1,PropLocAddr2,PropLocAddr3,PropLocCity,PropLocState,PropLocZip,Exchsale,Cntrinvcd,FiscalYear,ReportAgencyId,FederalAssetSalesId,WarehouseRecommendationId,ReimbursementTypeId,FscId,SupplyConditionId,DisposalConditionId,DemilitarizationId,UnitOfIssueId,StatusCodeId,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,MngtDecisionId,VehicleInfoId,Ns5RecordNumber,TransferOrderNumber,AcceptedByGsaDate")] ReportItem reportItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportItem);
        }

        // GET: ReportItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportItem = await _context.ReportItem.SingleOrDefaultAsync(m => m.ReportItemId == id);
            if (reportItem == null)
            {
                return NotFound();
            }
            return View(reportItem);
        }

        // POST: ReportItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportItemId,ReportNumber,LocationId,ItemName,Niin,ItemDescription,Model,PartNo,Qty,UnitCost,PicturesAvailable,ProceedsRetention,AgencyLocationCode,SpecialDescription,CompletedDate,Completed,ReqScrapPickup,CertDestruction,ReportCancelled,GsaComments,EngrDeision,EngrComments,EngrDecidedDate,ToEngDate,MngtDecision,ManagerComments,MngtDecidedDate,WarehouseComments,AccessLevel,SurplusReleaseDate,InternalReleaseDate,DropInternalFlag,ExcessRelDate,FscapCode,ReportCode,Make,AcquisitionDate,ManufacturedDate,Manufacturer,SpecialDesCode,Agybur,AgyControlNo,AppropCode,ClRefNo,ClLineItemNo,CountryCode,Drmo,FairMarketValue,HazmatCode,OverseasInd,PlantClCaseNo,ReimbReqd,Vessels50FeetOver,ShipName,GsaRegionCode,GsaSubmitRespNo,GsaSubmitTimeElap,GsaSubmitMsg,PropLocAddr1,PropLocAddr2,PropLocAddr3,PropLocCity,PropLocState,PropLocZip,Exchsale,Cntrinvcd,FiscalYear,ReportAgencyId,FederalAssetSalesId,WarehouseRecommendationId,ReimbursementTypeId,FscId,SupplyConditionId,DisposalConditionId,DemilitarizationId,UnitOfIssueId,StatusCodeId,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,MngtDecisionId,VehicleInfoId,Ns5RecordNumber,TransferOrderNumber,AcceptedByGsaDate")] ReportItem reportItem)
        {
            if (id != reportItem.ReportItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportItemExists(reportItem.ReportItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reportItem);
        }

        // GET: ReportItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportItem = await _context.ReportItem
                .SingleOrDefaultAsync(m => m.ReportItemId == id);
            if (reportItem == null)
            {
                return NotFound();
            }

            return View(reportItem);
        }

        // POST: ReportItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportItem = await _context.ReportItem.SingleOrDefaultAsync(m => m.ReportItemId == id);
            _context.ReportItem.Remove(reportItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportItemExists(int id)
        {
            return _context.ReportItem.Any(e => e.ReportItemId == id);
        }
    }
}
