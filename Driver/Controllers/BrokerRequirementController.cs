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
    public class BrokerRequirementController : Controller
    {
        private readonly DriverDbContext _context;

        public BrokerRequirementController(DriverDbContext context)
        {

            _context = context;
        }

        public IActionResult Index(string searchString)
        {
            var model = from m in _context.BrokerRequirements
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

            var brokerRequirement = await _context.BrokerRequirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brokerRequirement == null)
            {
                return NotFound();
            }
            BrokerRequirementDetailsViewModel brokerRequirementDetailsViewModel = new BrokerRequirementDetailsViewModel()
            {
                BrokerRequirement = brokerRequirement,
                PageTitle = "Country Details"
            };


            return View(brokerRequirementDetailsViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrokerRequirementCreateViewModel model)
        {
            if (ModelState.IsValid)
            {

                BrokerRequirement brokerRequirement = new BrokerRequirement
                {
                    
                    ContactPerson = model.ContactPerson,
                    LicenseNo = model.LicenseNo,
                    Mobile = model.Mobile,
                    ContactNo = model.ContactNo,
                    Email = model.Email,
                    Country = model.Country,
                    City = model.City,

                };
                _context.Add(brokerRequirement);
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

            var brokerRequirement = await _context.BrokerRequirements.FindAsync(id);
            if (brokerRequirement == null)
            {
                return NotFound();
            }
            // return View(country);

            BrokerRequirementEditViewModel brokerRequirementEditViewModel = new BrokerRequirementEditViewModel
            {
                //Id = brokerRequirement.Id,
                ContactPerson = brokerRequirement.ContactPerson,
                LicenseNo= brokerRequirement.LicenseNo,
                Mobile = brokerRequirement.Mobile,
                ContactNo = brokerRequirement.ContactNo,
                Email = brokerRequirement.Email,
                Country = brokerRequirement.Country,
                City = brokerRequirement.City,
            };
            return View(brokerRequirementEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,ContactPerson,LicenseNo,Mobile,ContactNo,Email,Country,City")] BrokerRequirement brokerRequirement)
        {
            if (id != brokerRequirement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brokerRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrokerRequirementExists(brokerRequirement.Id))
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
            return View(brokerRequirement);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brokerRequirement = await _context.BrokerRequirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brokerRequirement == null)
            {
                return NotFound();
            }

            return View(brokerRequirement);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brokerRequirement = await _context.BrokerRequirements.FindAsync(id);
            _context.BrokerRequirements.Remove(brokerRequirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrokerRequirementExists(int id)
        {
            return _context.BrokerRequirements.Any(e => e.Id == id);
        }
    }
}
