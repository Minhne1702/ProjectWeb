using System.ComponentModel.DataAnnotations;

namespace BOOKDB.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        [Display(Name = "Thể loại")]
        public string CategoryName { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
