namespace MRAShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}