using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options)
        { 
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithMany(u => u.Students)
                .HasForeignKey(s => s.CreatedBy);


            modelBuilder.Entity<User>().HasData(

                new User
                {
                Id = 1,
                Username = "admin",
                Password = "123456",
                Name = "Admin"
                },

                new User
                {
                Id = 2,
                Username = "Patya",
                Password = "123456",
                Name = "Prathamesh"
                }

                );
        }


    }
}
