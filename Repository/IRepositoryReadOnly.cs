using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using Repository.Data.Paging;

namespace Repository.Data
{
    public interface IRepositoryReadOnly<T> : IReadRepository<T> where T : class
    {
       
    }
}