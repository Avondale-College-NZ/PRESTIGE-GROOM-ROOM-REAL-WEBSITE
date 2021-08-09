using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Staffs> Staffs { get; set; }
    }
}