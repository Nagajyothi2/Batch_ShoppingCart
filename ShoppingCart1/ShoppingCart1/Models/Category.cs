using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(30)]
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; } = string.Empty;
        
    }
}
