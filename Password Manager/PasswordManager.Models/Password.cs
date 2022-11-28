using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace PasswordManager.Models
{
    public class Password
    {
        [Key]
        public int passwordId { get; set; }

        [Required]
        [Display(Name ="User Name")]
        public string userName { get; set; }

        [Required]
        [Display(Name ="Password")]
        public string userPassword { get; set; }

        [Required]
        public string site { get; set; }


    }
}
