using System;

namespace Material.Models
{
    public class Product
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Expiration { get; set; }
    }
}