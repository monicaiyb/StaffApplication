using Microsoft.EntityFrameworkCore;
namespace StaffApplication.Models
{
    public class StaffContext:DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {
        }

        public DbSet<Staff> Staff { get; set; }
    }
}
