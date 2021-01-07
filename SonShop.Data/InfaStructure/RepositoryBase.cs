using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonShop.Data.InfaStructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private SonShopDbContext dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected SonShopDbContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init());}
        }
        #endregion

    }
}
