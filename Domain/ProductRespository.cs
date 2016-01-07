using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain
{
    public class ProductRespository : IProductRespository
    {
        private static List<Product> products = new Product[]
        {
            new Product(){ Category = "C1", Id = 1, Name = "test1", Price = 10 }, 
            new Product(){ Category = "C2", Id = 2, Name = "test2", Price = 8 }, 
            new Product(){ Category = "C3", Id = 3, Name = "test3", Price = 10 }, 
            new Product(){ Category = "C3", Id = 4, Name = "test4", Price = 9 }, 
        }.ToList();

        public IList<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.FirstOrDefault(o => o.Id == id);
        }

        public Product Add(Product model)
        {
            model.Id = products.OrderByDescending(o => o.Id).First().Id + 1;
            products.Add(model);

            return model;
        }

        public void Remove(int id)
        {
            products.Remove(products.Find(product => product.Id == id));
        }

        public bool Update(Product model)
        {
            var product = products.FirstOrDefault(o => o.Id == model.Id);
            if (product == null)
            {
                throw new ArgumentNullException("model");
            }

            product.Category = model.Category;
            product.Name = model.Name;
            product.Price = model.Price;

            return true;
        }
    }
}
