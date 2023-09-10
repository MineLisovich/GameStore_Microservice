using Microsoft.EntityFrameworkCore;

namespace Microservice.GameStore.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        public DbSet<Users>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Users>().HasData(new Users
            {
                Id = 1,
                Login = "admin",
                Password = "admin",
                Email = "admin@gmail.com",
                Role = "Admin"

            });
            modelBuilder.Entity<Users>().HasData(new Users
            {
                Id = 2,
                Login = "user",
                Password = "user",
                Email = "user@gmail.com",
                Role = "User"

            });
        }
    }
}
