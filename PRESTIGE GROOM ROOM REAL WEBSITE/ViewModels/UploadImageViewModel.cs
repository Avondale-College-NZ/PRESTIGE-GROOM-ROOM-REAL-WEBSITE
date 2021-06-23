using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.ViewModels
{
    public class UploadImageViewModel
    {
        [Required]
        [Display(Name = "Image")]
        public IFormFile StaffPicture { get; set; }
    }
}
