using ExampleCancelationToken.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleCancelationToken.Infraextructura.Persistence.MysqlContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
        }
    }
}
