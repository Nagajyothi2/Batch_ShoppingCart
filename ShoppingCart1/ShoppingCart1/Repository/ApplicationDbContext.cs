using Microsoft.EntityFrameworkCore;

namespace ShoppingCart1.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
    }
}
