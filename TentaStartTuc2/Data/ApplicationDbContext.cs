using Microsoft.EntityFrameworkCore;

namespace TentaStartTuc2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}