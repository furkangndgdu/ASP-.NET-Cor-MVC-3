using BEU_ODEV_3.Models;
using Microsoft.EntityFrameworkCore;


namespace BEU_ODEV_3.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Course> Course { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<CourseUser> CourseUser { get; set; }
        public DbSet<UserType> UserType { get; set; } 
    }
}
