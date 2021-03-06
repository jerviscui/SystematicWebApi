﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace BaseService
{
    public interface IProductService
    {
        IList<Product> GetAll();

        Product Get(int id);

        Product Add(Product model);

        void Remove(int id);

        bool Update(Product model);

        IList<Product> GetByCatagory(string catagory);
    }
}
