using Microsoft.EntityFrameworkCore;
using StaffApplication.Models;

namespace StaffApplication.Data
{
    public class StaffContext : DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {
        }



        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
