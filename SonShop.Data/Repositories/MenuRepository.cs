using SonShop.Data.InfaStructure;
using SonShop.Model.Models;

namespace SonShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu >
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}