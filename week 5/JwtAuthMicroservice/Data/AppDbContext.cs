using JwtAuthMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthMicroservice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
