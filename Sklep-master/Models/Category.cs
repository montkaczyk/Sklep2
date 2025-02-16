using System.Collections.Generic;

namespace sklep.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }
}
