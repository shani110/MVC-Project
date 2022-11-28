using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace BulkyBook.Model
{
    public class ShopingCart
    {
        public Product Product { get; set; }

        [Range(1, 1000, ErrorMessage = "Range is not valid")]
        public int Count { get; set; }

    }
}
