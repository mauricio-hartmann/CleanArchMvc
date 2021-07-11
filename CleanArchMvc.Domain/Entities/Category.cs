using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
