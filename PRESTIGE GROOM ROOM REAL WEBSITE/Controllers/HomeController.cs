using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models;
using System.Diagnostics;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Location()
        {
            return View();
        }
        public IActionResult BookNow()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
