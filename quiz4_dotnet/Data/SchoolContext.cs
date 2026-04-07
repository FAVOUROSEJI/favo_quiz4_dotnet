using Microsoft.EntityFrameworkCore;

namespace quiz4_dotnet.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        // Add your DbSets here (tables)
        // public DbSet<Student> Students { get; set; }
        // public DbSet<Course> Courses { get; set; }
    }
}