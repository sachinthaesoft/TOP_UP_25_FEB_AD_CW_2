using Microsoft.EntityFrameworkCore;
using AD_CW2_FINAL.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options) { }
    public DbSet<Product> Products { get; set; }
}