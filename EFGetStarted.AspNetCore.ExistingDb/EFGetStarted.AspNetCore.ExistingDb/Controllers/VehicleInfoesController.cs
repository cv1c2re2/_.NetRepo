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
    public class VehicleInfoesController : Controller
    {
        private readonly EPPContext _context;

        public VehicleInfoesController(EPPContext context)
        {
            _context = context;
        }

        // GET: VehicleInfoes
        public async Task<IActionResult> Index()
        {
            var ePPContext = _context.VehicleInfo.Include(v => v.BodyStyle).Include(v => v.ColorGradient).Include(v => v.FuelType).Include(v => v.NoOfCylinders).Include(v => v.VehicleColor);
            return View(await ePPContext.ToListAsync());
        }

        // GET: VehicleInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleInfo = await _context.VehicleInfo
                .Include(v => v.BodyStyle)
                .Include(v => v.ColorGradient)
                .Include(v => v.FuelType)
                .Include(v => v.NoOfCylinders)
                .Include(v => v.VehicleColor)
                .SingleOrDefaultAsync(m => m.VehicleInfoId == id);
            if (vehicleInfo == null)
            {
                return NotFound();
            }

            return View(vehicleInfo);
        }

        // GET: VehicleInfoes/Create
        public IActionResult Create()
        {
            ViewData["BodyStyleId"] = new SelectList(_context.BodyStyle, "BodyStyleId", "CreatedBy");
            ViewData["ColorGradientId"] = new SelectList(_context.ColorGradient, "ColorGradientId", "CreatedBy");
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "FuelTypeId", "CreatedBy");
            ViewData["NoOfCylindersId"] = new SelectList(_context.NoOfCylinders, "NoOfCylindersId", "CreatedBy");
            ViewData["VehicleColorId"] = new SelectList(_context.VehicleColor, "VehicleColorId", "CreatedBy");
            return View();
        }

        // POST: VehicleInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleInfoId,VehicleIdNumber,ModelYear,EstMileage,NoCylinders,FuelTypeId,BodyStyleId,VehicleColorId,ColorGradientId,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,NoOfCylindersId,Transmission,AgencyClass,VehicleTag")] VehicleInfo vehicleInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BodyStyleId"] = new SelectList(_context.BodyStyle, "BodyStyleId", "CreatedBy", vehicleInfo.BodyStyleId);
            ViewData["ColorGradientId"] = new SelectList(_context.ColorGradient, "ColorGradientId", "CreatedBy", vehicleInfo.ColorGradientId);
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "FuelTypeId", "CreatedBy", vehicleInfo.FuelTypeId);
            ViewData["NoOfCylindersId"] = new SelectList(_context.NoOfCylinders, "NoOfCylindersId", "CreatedBy", vehicleInfo.NoOfCylindersId);
            ViewData["VehicleColorId"] = new SelectList(_context.VehicleColor, "VehicleColorId", "CreatedBy", vehicleInfo.VehicleColorId);
            return View(vehicleInfo);
        }

        // GET: VehicleInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleInfo = await _context.VehicleInfo.SingleOrDefaultAsync(m => m.VehicleInfoId == id);
            if (vehicleInfo == null)
            {
                return NotFound();
            }
            ViewData["BodyStyleId"] = new SelectList(_context.BodyStyle, "BodyStyleId", "CreatedBy", vehicleInfo.BodyStyleId);
            ViewData["ColorGradientId"] = new SelectList(_context.ColorGradient, "ColorGradientId", "CreatedBy", vehicleInfo.ColorGradientId);
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "FuelTypeId", "CreatedBy", vehicleInfo.FuelTypeId);
            ViewData["NoOfCylindersId"] = new SelectList(_context.NoOfCylinders, "NoOfCylindersId", "CreatedBy", vehicleInfo.NoOfCylindersId);
            ViewData["VehicleColorId"] = new SelectList(_context.VehicleColor, "VehicleColorId", "CreatedBy", vehicleInfo.VehicleColorId);
            return View(vehicleInfo);
        }

        // POST: VehicleInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleInfoId,VehicleIdNumber,ModelYear,EstMileage,NoCylinders,FuelTypeId,BodyStyleId,VehicleColorId,ColorGradientId,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,NoOfCylindersId,Transmission,AgencyClass,VehicleTag")] VehicleInfo vehicleInfo)
        {
            if (id != vehicleInfo.VehicleInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleInfoExists(vehicleInfo.VehicleInfoId))
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
            //ViewData["BodyStyleId"] = new SelectList(_context.BodyStyle, "BodyStyleId", "CreatedBy", vehicleInfo.BodyStyleId);
            //ViewData["ColorGradientId"] = new SelectList(_context.ColorGradient, "ColorGradientId", "CreatedBy", vehicleInfo.ColorGradientId);
            //ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "FuelTypeId", "CreatedBy", vehicleInfo.FuelTypeId);
            //ViewData["NoOfCylindersId"] = new SelectList(_context.NoOfCylinders, "NoOfCylindersId", "CreatedBy", vehicleInfo.NoOfCylindersId);
            //ViewData["VehicleColorId"] = new SelectList(_context.VehicleColor, "VehicleColorId", "CreatedBy", vehicleInfo.VehicleColorId);
            return View(vehicleInfo);
        }

        // GET: VehicleInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleInfo = await _context.VehicleInfo
                .Include(v => v.BodyStyle)
                .Include(v => v.ColorGradient)
                .Include(v => v.FuelType)
                .Include(v => v.NoOfCylinders)
                .Include(v => v.VehicleColor)
                .SingleOrDefaultAsync(m => m.VehicleInfoId == id);
            if (vehicleInfo == null)
            {
                return NotFound();
            }

            return View(vehicleInfo);
        }

        // POST: VehicleInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleInfo = await _context.VehicleInfo.SingleOrDefaultAsync(m => m.VehicleInfoId == id);
            _context.VehicleInfo.Remove(vehicleInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleInfoExists(int id)
        {
            return _context.VehicleInfo.Any(e => e.VehicleInfoId == id);
        }
    }
}
