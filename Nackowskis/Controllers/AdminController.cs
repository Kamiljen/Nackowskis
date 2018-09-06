using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nackowskis.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Auctions()
        {
            return View();
        }
    }
}