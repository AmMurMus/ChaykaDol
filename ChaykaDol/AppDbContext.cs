using Microsoft.EntityFrameworkCore;
using ChaykaDol.Models;

namespace ChaykaDol
{
    public class AppDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HealthRequest> HealthRequests { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ChaykaDB;Trusted_Connection=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}