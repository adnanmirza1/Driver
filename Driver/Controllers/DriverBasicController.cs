using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Driver.Data;
using Driver.Models.DbModels;
using Driver.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Driver.Controllers
{
    public class DriverBasicController : Controller
    {
        private readonly ILogger<DriverBasicController> _logger;
        private readonly DriverDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public DriverBasicController(ILogger<DriverBasicController> logger, DriverDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var model = from m in _context.DriverBasics
                        select m;
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DriverBasicCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                DriverBasic driverBasic = new DriverBasic
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmiratesId = model.EmiratesId,
                    WhatsappNo = model.WhatsappNo,
                    MobileNo = model.MobileNo,
                    InternationalNo = model.InternationalNo,
                    Language = model.Language,
                    Picture = uniqueFileName,
                    Nationality = model.Nationality,
                    DateOfBirth = model.DateOfBirth,
                    DateOfJoining = model.DateOfJoining,
                    PassportNo = model.PassportNo,
                    PassportExpiryDate = model.PassportExpiryDate,
                    VisaExpiry = model.VisaExpiry,
                    ResidenceCountry = model.ResidenceCountry,
                    CityName = model.CityName,
                    Address1 = model.Address1,
                    Address2 = model.Address2,
                    DriverType = model.DriverType,
                    Company = model.Company,

                };
                _context.Add(driverBasic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }



        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driverBasic = await _context.DriverBasics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driverBasic == null)
            {
                return NotFound();
            }
            DriverBasicDetailsViewModel driverBasicDetailsViewModel = new DriverBasicDetailsViewModel()
            {
                DriverBasic = driverBasic,
                PageTitle = "DriverBasics Details"
            };
            return View(driverBasicDetailsViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var driverBasic = await _context.DriverBasics.FindAsync(id);
            if (driverBasic == null)
            {
                return NotFound();
            }
            
            DriverBasicEditViewModel driverBasicEditViewModel = new DriverBasicEditViewModel
            {

                Id = driverBasic.Id,
                FirstName = driverBasic.FirstName,
                LastName = driverBasic.LastName,
                EmiratesId = driverBasic.EmiratesId,
                WhatsappNo = driverBasic.WhatsappNo,
                MobileNo = driverBasic.MobileNo,
                InternationalNo = driverBasic.InternationalNo,
                Language = driverBasic.Language,
                //Picture = uniqueFileName,
                Nationality = driverBasic.Nationality,
                DateOfBirth = driverBasic.DateOfBirth,
                DateOfJoining = driverBasic.DateOfJoining,
                PassportNo = driverBasic.PassportNo,
                PassportExpiryDate = driverBasic.PassportExpiryDate,
                VisaExpiry = driverBasic.VisaExpiry,
                ResidenceCountry = driverBasic.ResidenceCountry,
                CityName = driverBasic.CityName,
                Address1 = driverBasic.Address1,
                Address2 = driverBasic.Address2,
                DriverType = driverBasic.DriverType,
                Company = driverBasic.Company,


            };
            return View(driverBasicEditViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DriverBasicEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                DriverBasic driverBasic = _context.DriverBasics.FirstOrDefault(e => e.Id == model.Id);
                driverBasic.Id = model.Id;
                driverBasic.FirstName = driverBasic.FirstName;
                driverBasic.LastName = driverBasic.LastName;
                driverBasic.EmiratesId = driverBasic.EmiratesId;
                driverBasic.WhatsappNo = driverBasic.WhatsappNo;
                driverBasic.MobileNo = driverBasic.MobileNo;
                driverBasic.InternationalNo = driverBasic.InternationalNo;
                driverBasic.Language = driverBasic.Language;
                //driverBasic.Picture = uniqueFileName;
                driverBasic.Nationality = driverBasic.Nationality;
                driverBasic.DateOfBirth = driverBasic.DateOfBirth;
                driverBasic.DateOfJoining = driverBasic.DateOfJoining;
                driverBasic.PassportNo = driverBasic.PassportNo;
                driverBasic.PassportExpiryDate = driverBasic.PassportExpiryDate;
                driverBasic.VisaExpiry = driverBasic.VisaExpiry;
                driverBasic.ResidenceCountry = driverBasic.ResidenceCountry;
                driverBasic.CityName = driverBasic.CityName;
                driverBasic.Address1 = driverBasic.Address1;
                driverBasic.Address2 = driverBasic.Address2;
                driverBasic.DriverType = driverBasic.DriverType;
                driverBasic.Company = driverBasic.Company;


                try
                {
                    _context.Update(model);
                    _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DriverExists(model.Id))
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
            return View(model);
            //return View(student);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var driverBasic = await _context.DriverBasics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driverBasic == null)
            {
                return NotFound();
            }

            return View(driverBasic);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.DriverBasics.FindAsync(id);
            _context.DriverBasics.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private string UploadedFile(DriverBasicCreateViewModel model)
        {
            string uniqueFileName = null;

            if (model.Picture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Picture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        private bool DriverExists(int id)
        {
            return _context.DriverBasics.Any(e => e.Id == id);
        }
    }
}
