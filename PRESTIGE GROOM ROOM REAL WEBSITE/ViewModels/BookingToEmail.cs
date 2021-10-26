using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.ViewModels
{
    public class BookingToEmailViewModel
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