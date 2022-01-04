using BackEndProje.DATA;
using BackEndProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ContactInfoController : Controller
    {
        private readonly AppDbContext _context;

        public ContactInfoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ContactInfo> model = _context.ContactInfos.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ContactInfo model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactInfos.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);

        }
        public IActionResult Update(int id)
        {
            return View(_context.ContactInfos.Find(id));
        }

        [HttpPost]
        public IActionResult Update(ContactInfo model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactInfos.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            ContactInfo contactInfo = _context.ContactInfos.Find(id);
            _context.ContactInfos.Remove(contactInfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
