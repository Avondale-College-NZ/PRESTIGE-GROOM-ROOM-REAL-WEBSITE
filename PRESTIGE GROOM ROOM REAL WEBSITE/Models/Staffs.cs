using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models
{
    public class Staffs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Qualification { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
    }
}
