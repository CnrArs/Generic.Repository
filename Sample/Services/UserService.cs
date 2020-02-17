using Microsoft.EntityFrameworkCore.Query;
using Repository.Data;
using Repository.Data.Paging;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sample.Services
{
    public class UserService<T> : IUserService<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork Unit)
        {
            unitOfWork = Unit;
        }

        public IPaginate<T> GetList()
        {
            return unitOfWork.GetRepository<T>().GetList();
        }

        public IPaginate<T> Query(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, int index = 0, int size = 20, bool disableTracking = true)
        {
            return unitOfWork.GetRepository<T>().GetList(predicate: predicate, orderBy: orderBy, include: include, index: index, size: size, disableTracking: disableTracking);
        }

        public IPaginate<T> Where(Expression<Func<T, bool>> predicate = null)
        {
            return unitOfWork.GetRepository<T>().GetList(predicate: predicate);
        }

        public int Insert(T Entity)
        {
            unitOfWork.GetRepository<T>().Add(Entity);
            return unitOfWork.SaveChanges();
        }

        public int Insert(T[] Entity)
        {
            unitOfWork.GetRepository<T>().Add(Entity);
            return unitOfWork.SaveChanges();
        }

        public int Delete(T Entity)
        {
            unitOfWork.GetRepository<T>().Delete(Entity);
            return unitOfWork.SaveChanges();
        }

        public int Delete(T[] Entity)
        {
            unitOfWork.GetRepository<T>().Delete(Entity);
            return unitOfWork.SaveChanges();
        }

        public int Update(T Entity)
        {
            unitOfWork.GetRepository<T>().Update(Entity);
            return unitOfWork.SaveChanges();
        }

        public int Update(T[] Entity)
        {
            unitOfWork.GetRepository<T>().Update(Entity);
            return unitOfWork.SaveChanges();
        }
    }
}
