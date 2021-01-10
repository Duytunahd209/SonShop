using SonShop.Data.InfaStructure;
using SonShop.Model.Models;

namespace SonShop.Data.Repositories
{
    public interface IFooterRepository: IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}