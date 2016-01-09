using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;
using Domain.Entity;

namespace BaseService
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRespository;

        public ProductService(IRepository<Product> productRespository)
        {
            _productRespository = productRespository;
        }

        public IList<Product> GetAll()
        {
            return _productRespository.Table.Where(o => o.IsValid).ToList();
        }

        public Product Get(int id)
        {
            return _productRespository.Table.FirstOrDefault(o => o.IsValid && o.Id == id);
        }

        public Product Add(Product model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            _productRespository.Add(model);

            return model;
        }

        public void Remove(int id)
        {
            var product = _productRespository.Table.FirstOrDefault(o => o.Id == id);
            if (product != null)
            {
                _productRespository.Delete(product);
            }
        }

        public bool Update(Product model)
        {
            _productRespository.Update(model);

            return true;
        }

        public IList<Product> GetByCatagory(string catagory)
        {
            return _productRespository.Table.Where(o => o.IsValid && o.Category.Equals(catagory)).ToList();
        }
    }
}
