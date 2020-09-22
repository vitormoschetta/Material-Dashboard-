using System;
using System.Collections.Generic;
using System.Linq;
using Material.Models;

namespace Material.Repositories
{
    public class ProductFakeRepository
    {
        public List<Product> products = new List<Product>();

        public ProductFakeRepository()
        {
            for (int i = 0; i < 10; i++)
            {
                var product = new Product();
                product.Id = Guid.NewGuid();
                product.Name = "Product " + i;
                product.Price = i;
                product.Expiration = DateTime.Now.AddDays(60 + i);

                products.Add(product);
            }
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(Guid id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Product product)
        {
            products.Add(product);
        }

        public void Update(Product product)
        {
            foreach (var item in products)
            {
                if (item.Id == product.Id)
                {
                    products.Remove(item);
                    product.Id = item.Id;
                    products.Add(product);
                }

            }
        }

        public void Delete(Guid id)
        {
            foreach (var item in products)
            {
                if (item.Id == id)
                {
                    products.Remove(item);
                }

            }
        }
    }
}