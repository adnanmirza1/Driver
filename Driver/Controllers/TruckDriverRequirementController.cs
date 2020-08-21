using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Driver.Data;
using Driver.Models.DbModels;
using Driver.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Driver.Controllers
{
    public class TruckDriverRequirementController : Controller
    {
        private readonly DriverDbContext _context;

        public TruckDriverRequirementController(DriverDbContext context)
        {

            _context = context;
        }

        public IActionResult Index(string searchString)
        {
            var model = from m in _context.TruckDriverRequirements
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                model = model.Where(s => s.CompanyName.Contains(searchString));
            }


            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckDriverRequirement = await _context.TruckDriverRequirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (truckDriverRequirement == null)
            {
                return NotFound();
            }
            TruckDriverRequirementDetailsViewModel truckDriverRequirementDetailsViewModel = new TruckDriverRequirementDetailsViewModel()
            {
                TruckDriverRequirement = truckDriverRequirement,
                PageTitle = "Truc kDriver Details"
            };


            return View(truckDriverRequirementDetailsViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TruckDriverRequirementCreateViewModel model)
        {
            if (ModelState.IsValid)
            {

                TruckDriverRequirement truckDriverRequirement = new TruckDriverRequirement
                {

                    ContactPerson = model.ContactPerson,
                    LicenseNo = model.LicenseNo,
                    Mobile = model.Mobile,
                    Email = model.Email,
                    Country = model.Country,
                    City = model.City,

                };
                _context.Add(truckDriverRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckDriverRequirement = await _context.TruckDriverRequirements.FindAsync(id);
            if (truckDriverRequirement == null)
            {
                return NotFound();
            }
            // return View(country);

            TruckDriverRequirementEditViewModel truckDriverRequirementEditViewModel = new TruckDriverRequirementEditViewModel
            {
                //Id = brokerRequirement.Id,
                ContactPerson = truckDriverRequirement.ContactPerson,
                LicenseNo = truckDriverRequirement.LicenseNo,
                Mobile = truckDriverRequirement.Mobile,
                Email = truckDriverRequirement.Email,
                Country = truckDriverRequirement.Country,
                City = truckDriverRequirement.City,
            };
            return View(truckDriverRequirementEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,ContactPerson,LicenseNo,Mobile,Email,Country,City")] TruckDriverRequirement truckDriverRequirement)
        {
            if (id != truckDriverRequirement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(truckDriverRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TruckDriverRequirementExists(truckDriverRequirement.Id))
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
            return View(truckDriverRequirement);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truckDriverRequirement = await _context.TruckDriverRequirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (truckDriverRequirement == null)
            {
                return NotFound();
            }

            return View(truckDriverRequirement);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var truckDriverRequirement = await _context.TruckDriverRequirements.FindAsync(id);
            _context.TruckDriverRequirements.Remove(truckDriverRequirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TruckDriverRequirementExists(int id)
        {
            return _context.TruckDriverRequirements.Any(e => e.Id == id);
        }
    }
}
