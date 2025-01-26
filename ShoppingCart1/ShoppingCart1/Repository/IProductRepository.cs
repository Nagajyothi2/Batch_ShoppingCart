using ShoppingCart1.Models;

namespace ShoppingCart1.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

    }
}
