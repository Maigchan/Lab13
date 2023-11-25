using Microsoft.EntityFrameworkCore;

namespace Demo2023API.Models
{
    public class InvoiceContext : DbContext
        {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
