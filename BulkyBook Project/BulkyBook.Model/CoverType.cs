using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace BulkyBook.Model
{
    public class CoverType
    {
        [Key]
        public int cover_id { get; set; }

        [Required]

        [Display(Name ="Cover Type")]
        [MaxLength(50)]
        public string cover_name { get; set; }
    }
}
