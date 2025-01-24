using ShoppingCart1.Models;

namespace ShoppingCart1.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        } 
        public void Update(Category obj)
        {
            _db.Category.Update(obj);
        }
    }
}
