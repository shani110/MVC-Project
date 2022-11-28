using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<category>, ICategoryRepository
    {
        private DataContext _db;
        public CategoryRepository(DataContext db) :base(db)
        {
            _db = db;
        }

       

        void ICategoryRepository.Save()
        {
            _db.SaveChanges();
        }

        void ICategoryRepository.Update(category obj)
        {
            _db.categories.Update(obj);
        }
    }
}
