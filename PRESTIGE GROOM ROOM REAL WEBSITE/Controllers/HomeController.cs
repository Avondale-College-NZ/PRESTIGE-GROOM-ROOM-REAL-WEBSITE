using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models;
using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Helpers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks; // added this namespace for async to function

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration configuration;
        private readonly IWebHostEnvironment webHostEnvironment; //created readonly variable of type IWebHostEnvironment

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment, IConfiguration _configuration)
        {
            configuration = _configuration;
            _logger = logger;
            webHostEnvironment = hostEnvironment;
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

        [HttpGet]
        public IActionResult Getaquote()
        {
            return View();
        }

        [HttpPost] //changed this to IActionResult asyc Task method
        public async Task<IActionResult> MakeaBooking(BookingToEmailViewModel bookingToEmail, IFormFile[] attachments)
        {
            if (ModelState.IsValid)
            {
                var body = "Name: " + bookingToEmail.Name + "<br>Email: " + bookingToEmail.Email + "<br>HaircutStyle: " + bookingToEmail.HaircutStyle + "<br>Time: " + bookingToEmail.Time + "<br>" + bookingToEmail.Message + "<br>";
                var mailHelper = new MailHelper(configuration);
                List<string> fileNames = null;
                if (attachments != null && attachments.Length > 0)
                {
                    fileNames = new List<string>();
                    foreach (IFormFile attachment in attachments)
                    {
                        var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads",attachment.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await attachment.CopyToAsync(stream); //added await keyword for this to take place before redirect to page
                        }
                        fileNames.Add(path);
                    }
                }
                if (mailHelper.Send(bookingToEmail.Email, configuration["Gmail:Username"], bookingToEmail.Subject, body, fileNames))
                {
                    ViewBag.msg = "Sent Mail Successfully";
                }
                else
                {
                    ViewBag.msg = "Failed";
                }
            }
            return RedirectToAction("Index"); //you can redirect to any of the action methods above or even the Home page = Index
        }
    }
}
