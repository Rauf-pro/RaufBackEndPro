using BackEndProje.DATA;
using BackEndProje.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Areas.Admin.Controllers
{
    [Area("admin")]
    public class SettingController : Controller
    {
        
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            Setting model = _context.Settings.FirstOrDefault();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Setting model)
        {
            if (ModelState.IsValid)
            {
                if (model.FileImage.ContentType == "image/jpeg" || model.FileImage.ContentType == "image/png")
                {
                    if (model.FileImage.Length <= 2010000)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.FileImage.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.FileImage.CopyTo(stream);
                        }
                        model.Logo = fileName;
                        _context.Settings.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(model);

                    }
                }
                else
                {
                    return View(model);
                }
            }

            return View(model);

        }
        public IActionResult Update(int id)
        {
            return View(_context.Settings.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (model.FileImage != null)
            {
                if (ModelState.IsValid)
                {
                    if (model.FileImage.ContentType == "image/jpeg" || model.FileImage.ContentType == "image/png")
                    {
                        if (model.FileImage.Length <= 2010000)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.FileImage.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                model.FileImage.CopyTo(stream);
                            }
                            model.Logo = fileName;
                            _context.Settings.Update(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            return View(model);

                        }
                    }
                    else
                    {
                        return View(model);
                    }
                }
            }
            else
            {
                return RedirectToAction("Update");
            }


            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Setting setting = _context.Settings.Find(id);
            _context.Settings.Remove(setting);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
    

