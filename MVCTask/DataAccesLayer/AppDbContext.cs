using Microsoft.EntityFrameworkCore;
using MVCTask.Models;

namespace MVCTask.DataAccesLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<TeacherStudent> TeacherStudents { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        {
            
        }

    }
}
