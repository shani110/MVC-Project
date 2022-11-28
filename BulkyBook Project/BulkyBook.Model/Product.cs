using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace BulkyBook.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
         public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1,10000)]
        public double Price50 { get; set; }
        
        public string ImgUrl { get; set; }
      public int categoryId { get; set; }   
        public category category { get; set; }
        
        public int CoverTypeId { get; set; }
        public CoverType CoverType { get; set; }
        

    }
}
