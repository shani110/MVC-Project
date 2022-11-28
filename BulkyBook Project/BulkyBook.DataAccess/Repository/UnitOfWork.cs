﻿using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _db;
        public UnitOfWork(DataContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType  { get; private set; }
        public IProductRepository Product { get; private set; }


        void IUnitOfWork.Save()
        {
          _db.SaveChanges();
        }
    }
}
