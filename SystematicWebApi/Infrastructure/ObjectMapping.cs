using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystematicWebApi.Models.Products;
using AutoMapper;
using Common;
using Domain.Entity;

namespace SystematicWebApi.Infrastructure
{
    public class ObjectMapping : IObjectMapping
    {
        public void MapperConfig()
        {
            Mapper.CreateMap<Product, ProductModel>();
            Mapper.CreateMap<ProductModel, Product>();
        }
    }
}