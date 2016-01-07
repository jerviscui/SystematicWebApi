using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Entity;

namespace BaseService
{
    public class ProductService : IProductService
    {
        private readonly IProductRespository _productRespository;

        public ProductService(IProductRespository productRespository)
        {
            _productRespository = productRespository;
        }

        public IList<Product> GetAll()
        {
            return _productRespository.GetAll();
        }

        public Product Get(int id)
        {
            return _productRespository.Get(id);
        }

        public Product Add(Product model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }

            return _productRespository.Add(model);
        }

        public void Remove(int id)
        {
            _productRespository.Remove(id);
        }

        public bool Update(Product model)
        {
            return _productRespository.Update(model);
        }

        public IList<Product> GetByCatagory(string catagory)
        {
            return _productRespository.GetAll().Where(o => o.Category.Equals(catagory)).ToList();
        }
    }
}
