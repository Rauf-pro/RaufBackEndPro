using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Controllers
{
    public class BlogDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
