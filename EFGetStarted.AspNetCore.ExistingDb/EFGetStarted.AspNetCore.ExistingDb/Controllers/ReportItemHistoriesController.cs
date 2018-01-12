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
    public class ReportItemHistoriesController : Controller
    {
        private readonly EPPContext _context;

        public ReportItemHistoriesController(EPPContext context)
        {
            _context = context;
        }

        // GET: ReportItemHistories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportItemHistory.ToListAsync());
        }

        // GET: ReportItemHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportItemHistory = await _context.ReportItemHistory
                .SingleOrDefaultAsync(m => m.ReportItemHistoryId == id);
            if (reportItemHistory == null)
            {
                return NotFound();
            }

            return View(reportItemHistory);
        }

        // GET: ReportItemHistories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportItemHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportItemHistoryId,ReportItemId,ReportNumber,LocationId,ItemName,Niin,ItemDescription,Model,PartNo,Qty,UnitCost,PicturesAvailable,ProceedsRetention,AgencyLocationCode,SpecialDescription,CompletedDate,Completed,ReqScrapPickup,CertDestruction,ReportCancelled,GsaComments,EngrDeision,EngrComments,EngrDecidedDate,ToEngDate,MngtDecision,ManagerComments,MngtDecidedDate,WarehouseComments,AccessLevel,SurplusReleaseDate,InternalReleaseDate,DropInternalFlag,ExcessRelDate,FscapCode,ReportCode,Make,AcquisitionDate,ManufacturedDate,Manufacturer,SpecialDesCode,Agybur,AgyControlNo,AppropCode,ClRefNo,ClLineItemNo,CountryCode,Drmo,FairMarketValue,HazmatCode,OverseasInd,PlantClCaseNo,ReimbReqd,Vessels50FeetOver,ShipName,GsaRegionCode,GsaSubmitRespNo,GsaSubmitTimeElap,GsaSubmitMsg,PropLocAddr1,PropLocAddr2,PropLocAddr3,PropLocCity,PropLocState,PropLocZip,Exchsale,Cntrinvcd,FiscalYear,ReportAgencyId,FederalAssetSalesId,ReimbursementTypeId,FscId,SupplyConditionId,DisposalConditionId,DemilitarizationId,UnitOfIssueId,StatusCodeId,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,MngtDecisionId")] ReportItemHistory reportItemHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportItemHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportItemHistory);
        }

        // GET: ReportItemHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportItemHistory = await _context.ReportItemHistory.SingleOrDefaultAsync(m => m.ReportItemHistoryId == id);
            if (reportItemHistory == null)
            {
                return NotFound();
            }
            return View(reportItemHistory);
        }

        // POST: ReportItemHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportItemHistoryId,ReportItemId,ReportNumber,LocationId,ItemName,Niin,ItemDescription,Model,PartNo,Qty,UnitCost,PicturesAvailable,ProceedsRetention,AgencyLocationCode,SpecialDescription,CompletedDate,Completed,ReqScrapPickup,CertDestruction,ReportCancelled,GsaComments,EngrDeision,EngrComments,EngrDecidedDate,ToEngDate,MngtDecision,ManagerComments,MngtDecidedDate,WarehouseComments,AccessLevel,SurplusReleaseDate,InternalReleaseDate,DropInternalFlag,ExcessRelDate,FscapCode,ReportCode,Make,AcquisitionDate,ManufacturedDate,Manufacturer,SpecialDesCode,Agybur,AgyControlNo,AppropCode,ClRefNo,ClLineItemNo,CountryCode,Drmo,FairMarketValue,HazmatCode,OverseasInd,PlantClCaseNo,ReimbReqd,Vessels50FeetOver,ShipName,GsaRegionCode,GsaSubmitRespNo,GsaSubmitTimeElap,GsaSubmitMsg,PropLocAddr1,PropLocAddr2,PropLocAddr3,PropLocCity,PropLocState,PropLocZip,Exchsale,Cntrinvcd,FiscalYear,ReportAgencyId,FederalAssetSalesId,ReimbursementTypeId,FscId,SupplyConditionId,DisposalConditionId,DemilitarizationId,UnitOfIssueId,StatusCodeId,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,MngtDecisionId")] ReportItemHistory reportItemHistory)
        {
            if (id != reportItemHistory.ReportItemHistoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportItemHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportItemHistoryExists(reportItemHistory.ReportItemHistoryId))
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
            return View(reportItemHistory);
        }

        // GET: ReportItemHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportItemHistory = await _context.ReportItemHistory
                .SingleOrDefaultAsync(m => m.ReportItemHistoryId == id);
            if (reportItemHistory == null)
            {
                return NotFound();
            }

            return View(reportItemHistory);
        }

        // POST: ReportItemHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportItemHistory = await _context.ReportItemHistory.SingleOrDefaultAsync(m => m.ReportItemHistoryId == id);
            _context.ReportItemHistory.Remove(reportItemHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportItemHistoryExists(int id)
        {
            return _context.ReportItemHistory.Any(e => e.ReportItemHistoryId == id);
        }
    }
}
