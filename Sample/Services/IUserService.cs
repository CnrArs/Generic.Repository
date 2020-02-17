using Microsoft.EntityFrameworkCore.Query;
using Repository.Data.Paging;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sample.Services
{
    public interface IUserService<T>
    {
        int Delete(T Entity);
        int Delete(T[] Entity);
        IPaginate<T> GetList();
        int Insert(T Entity);
        int Insert(T[] Entity);
        IPaginate<T> Query(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, int index = 0, int size = 20, bool disableTracking = true);
        int Update(T Entity);
        int Update(T[] Entity);
        IPaginate<T> Where(Expression<Func<T, bool>> predicate = null);
    }
}