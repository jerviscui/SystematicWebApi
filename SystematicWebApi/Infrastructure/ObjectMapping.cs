using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystematicWebApi.Models.Order;
using SystematicWebApi.Models.OrderDetail;
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

            Mapper.CreateMap<Order, OrderModel>();

            Mapper.CreateMap<OrderDetail, OrderDetailModel>();
        }
    }
}