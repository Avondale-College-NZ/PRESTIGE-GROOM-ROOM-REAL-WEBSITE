using Microsoft.AspNetCore.Mvc;
using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Controllers
{
    public class HomeController2
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactModel model)
        {

            var mail = new MailMessage();
            mail.To.Add(new MailAddress(model.SenderEmail));
            mail.Subject = "Your Email Subject";
            mail.Body = string.Format("<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>", model.SenderName, mail.SenderEmail, model.Message);
            mail.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(mail);
                return RedirectToAction("SuccessMessage");
            }
        }

        private ActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        private ActionResult View(ContactModel model)
        {
            throw new NotImplementedException();
        }

        public ActionResult SuccessMessage()
        {
            return View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}