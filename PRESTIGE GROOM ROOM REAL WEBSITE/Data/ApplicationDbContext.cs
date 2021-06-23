using PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Models;
using Microsoft.EntityFrameworkCore;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<Staffs> Staffs { get; set; }
    }
}