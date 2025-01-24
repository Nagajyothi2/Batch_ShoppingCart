using ShoppingCart1.Models;

namespace ShoppingCart1.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);

    }
}
