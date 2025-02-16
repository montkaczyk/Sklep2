using System.ComponentModel.DataAnnotations;

namespace sklep.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [Range(0.01, 10000)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 1000)]
        public int StockQuantity { get; set; }
    }
}
