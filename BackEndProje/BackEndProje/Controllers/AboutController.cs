using BackEndProje.DATA;
using BackEndProje.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmAbout model = new VmAbout();
            model.Banner = _context.Banners.FirstOrDefault(b => b.Page == "About"); 

            return View(model);
        }
    }
}
