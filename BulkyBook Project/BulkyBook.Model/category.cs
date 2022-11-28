using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace BulkyBook.Model
{
    public class category
    {
        [Key]
        public int id {  get; set; }
        [Required]
        

        public string Name { get; set; }
        [DisplayName("Display order")]
        [Range(1,100, ErrorMessage ="should be between one and hundred")]
        public int DisplayOrder { get; set; }
        public DateTime createdDate { get; set; } = DateTime.Now;
    }
}
