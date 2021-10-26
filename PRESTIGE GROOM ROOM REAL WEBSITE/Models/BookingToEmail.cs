using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models
{
    public class BookingToEmail
    {
        [Required, Display(Name = "Your name")]
        public string Name { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string Email { get; set; }
        [Required]

        public string HaircutStyle { get; set; }
        public string Time { get; set; }

    }
}