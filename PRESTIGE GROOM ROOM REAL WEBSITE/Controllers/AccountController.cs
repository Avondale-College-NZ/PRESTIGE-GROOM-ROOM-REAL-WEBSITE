using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Register()
        {
            return View();
        }
    }
}