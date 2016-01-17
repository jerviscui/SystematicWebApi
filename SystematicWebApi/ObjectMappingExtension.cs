using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystematicWebApi.Models.Order;
using SystematicWebApi.Models.OrderDetail;
using SystematicWebApi.Models.Products;
using AutoMapper;
using Domain.Entity;

namespace SystematicWebApi
{
    public static class ObjectMappingExtension
    {
        public static ProductModel ToModel(this Product entity)
        {
            return Mapper.Map<Product, ProductModel>(entity);
        }

        public static Product ToEntity(this ProductModel model)
        {
            return Mapper.Map<ProductModel, Product>(model);
        }

        public static OrderModel ToModel(this Order entity)
        {
            return Mapper.Map<Order, OrderModel>(entity);
        }

        public static OrderDetailModel ToModel(this OrderDetail entity)
        {
            return Mapper.Map<OrderDetail, OrderDetailModel>(entity);
        }
    }
}