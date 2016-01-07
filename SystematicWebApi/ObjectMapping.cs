using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystematicWebApi.Models.Products;
using AutoMapper;
using Domain.Entity;

namespace SystematicWebApi
{
    public static class ObjectMapping
    {
        public static ProductModel ToModel(this Product entity)
        {
            return Mapper.Map<Product, ProductModel>(entity);
        }

        public static Product ToEntity(this ProductModel model)
        {
            return Mapper.Map<ProductModel, Product>(model);
        }
    }
}