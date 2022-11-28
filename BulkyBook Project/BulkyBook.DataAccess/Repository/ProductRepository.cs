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
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        private DataContext _db;
        public ProductRepository(DataContext db) :base(db)
        {
            _db = db;
        }

       

        void IProductRepository.Save()
        {
            _db.SaveChanges();
        }

        void IProductRepository.Update(Product obj)
        {
            var objFromDb = _db.products.FirstOrDefault(p => p.Id == obj.Id);
            if (objFromDb != null) 
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price50 = obj.Price50;
                objFromDb.categoryId = obj.categoryId;
                objFromDb.Description = obj.Description;
                objFromDb.CoverTypeId = obj.CoverTypeId;
                objFromDb.Author = obj.Author;
                objFromDb.categoryId = obj.categoryId;
              
                if (obj.ImgUrl != null) 
                {
                    objFromDb.ImgUrl = obj.ImgUrl;
                }
               

            }
        }
    }
}
