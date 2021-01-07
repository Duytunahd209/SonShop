namespace SonShop.Data.InfaStructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SonShopDbContext dbContext;

        public SonShopDbContext Init()
        {
            return dbContext ?? (dbContext = new SonShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}