using BackEndProje.DATA;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private UserManager<AppDbContext> _userManager;

        public AccountController(UserManager<AppDbContext> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users);
      
        }


       
    }


}
