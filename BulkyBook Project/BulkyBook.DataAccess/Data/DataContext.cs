using BulkyBook.Model;
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace BulkyBook.DataAccess.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<category> categories { get; set; }
        public DbSet<CoverType> coverTypes { get; set; }
        public DbSet<Product>   products { get; set; }



    }
}
