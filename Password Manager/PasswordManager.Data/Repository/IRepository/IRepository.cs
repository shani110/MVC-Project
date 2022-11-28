using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category

        void Add(T entity);
        void Remove(T entity);
    }
}
