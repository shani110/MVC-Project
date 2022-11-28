using Microsoft.EntityFrameworkCore;
using PasswordManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }
      
        public DbSet<Address> address { get; set; }
        public DbSet<Password> password { get; set; }
        public DbSet<Payment> payment { get; set; }

    }
}
