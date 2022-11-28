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
    public class CoverTypeRepository : Repository<CoverType>,ICoverTypeRepository
    {
        private DataContext _db;
        public CoverTypeRepository(DataContext db) :base(db)
        {
            _db = db;
        }

       

        void ICoverTypeRepository.Save()
        {
            _db.SaveChanges();
        }

        void ICoverTypeRepository.Update(CoverType obj)
        {
            _db.coverTypes.Update(obj);
        }
    }
}
