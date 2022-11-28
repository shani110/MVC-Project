﻿using BulkyBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
   public  interface ICategoryRepository :IRepository<category>
    {
        void Update(category obj);
        void Save();

    }
}
