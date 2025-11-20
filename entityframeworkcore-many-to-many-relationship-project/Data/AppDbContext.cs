using entityframeworkcore_many_to_many_relationship_project.Models;
using Microsoft.EntityFrameworkCore;

namespace entityframeworkcore_many_to_many_relationship_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
