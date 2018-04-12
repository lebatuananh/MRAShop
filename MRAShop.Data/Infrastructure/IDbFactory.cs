using System;

namespace MRAShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
       MRAShopDbContext Init();
    }
}