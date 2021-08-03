using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<Staffs> Staffs { get; set; }
    }
}