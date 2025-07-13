using Microsoft.EntityFrameworkCore;
using SimpleProductApi.Models;

namespace SimpleProductApi.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
