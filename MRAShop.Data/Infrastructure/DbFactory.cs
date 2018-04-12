namespace MRAShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MRAShopDbContext dbContext;

        public MRAShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MRAShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}