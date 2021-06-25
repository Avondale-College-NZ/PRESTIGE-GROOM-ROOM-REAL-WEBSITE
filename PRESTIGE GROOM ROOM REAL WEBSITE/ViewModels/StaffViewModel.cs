using System;
using System.ComponentModel.DataAnnotations;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.ViewModels
{
    public class StaffViewModel : EditImageViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string StaffName { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public int Experience { get; set; }
    }
}