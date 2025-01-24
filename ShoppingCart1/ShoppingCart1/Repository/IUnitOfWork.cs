namespace ShoppingCart1.Repository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category {  get; }
        void Save();
    }
}
