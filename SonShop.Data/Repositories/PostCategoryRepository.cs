using SonShop.Data.InfaStructure;
using SonShop.Model.Models;

namespace SonShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory >
    {
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}