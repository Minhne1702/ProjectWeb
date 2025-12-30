using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Lab08.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên hãng không được để trống")]
        public string Name { get; set; } = null!;

        public string? Country { get; set; }

        [ValidateNever]
        public ICollection<Car> Car { get; set; } = new List<Car>();
    }
}