using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T as category
        T GetFirstORDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);

        // geting all categoris from database
        IEnumerable<T> GetAll(string? includeProperties = null);

        // for adding Categories 
        void Add(T entity);

        // for remove
        void Remove(T entity);

        // for remove multiple range
        
        void RemoveRange(IEnumerable<T> entities);
    }
}
