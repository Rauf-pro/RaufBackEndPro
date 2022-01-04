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
    public class AboutController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<AboutUs> model = _context.AboutUs.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AboutUs model)
        {
            if (ModelState.IsValid)
            {
                if (model.FileImage.ContentType == "image/jpeg" || model.FileImage.ContentType == "image/png")
                {
                   if (model.FileImage.Length <= 2097152)
                   {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.FileImage.FileName;
                       string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                       using (var stream = new FileStream(filePath, FileMode.Create))
                       {
                           model.FileImage.CopyTo(stream);
                        }
                        model.Image = fileName;
                        _context.AboutUs.Add(model);
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
            return View(_context.AboutUs.Find(id));
        }

        [HttpPost]
        public IActionResult Update(AboutUs model)
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
                            model.Image = fileName;
                            _context.AboutUs.Update(model);
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
            AboutUs about = _context.AboutUs.Find(id);
            _context.AboutUs.Remove(about);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


    
    


