using System.ComponentModel.DataAnnotations;

namespace Mission06_Taylor.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public required string CategoryName { get; set; }
    }
}
