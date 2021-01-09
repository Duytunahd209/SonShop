using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SonShop.Data.InfaStructure
{
    public interface IRepository<T> where T : class
    {
        //Mask an entity as new
        void Add(T entity);

        //Mask an entity as modified
        void Update(T entity);
        //Mask an entity to be removed
        void Delete(T entity);
        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);
        //Get an entity by int ID
        T GetSingleByID(int ID);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, String[] includeds = null);
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);

    }
}
