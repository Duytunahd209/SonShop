using System;

namespace SonShop.Data.InfaStructure
{
    public interface IDbFactory : IDisposable
    {
        SonShopDbContext Init();
    }
}