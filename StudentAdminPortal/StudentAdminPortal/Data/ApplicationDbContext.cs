using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Models;

namespace StudentAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
