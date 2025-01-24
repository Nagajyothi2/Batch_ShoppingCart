using Microsoft.EntityFrameworkCore;
using ShoppingCart1.Models;

namespace ShoppingCart1.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
           
        }
        public DbSet<Category>Category {  get; set; }
    }
}
