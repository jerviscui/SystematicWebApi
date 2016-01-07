using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystematicWebApi.Models.Products;
using BaseService;

namespace SystematicWebApi.Controllers
{
    /// <summary>
    /// 产品接口
    /// </summary>
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// 获取所有产品列表
        /// </summary>
        /// <returns></returns>
        public IList<ProductModel> GetAllProducts()
        {
            var list = _productService.GetAll();
            return list.Select(o => o.ToModel()).ToList();
        }

        /// <summary>
        /// 根据id获取产品详情
        /// </summary>
        /// <param name="id">产品id</param>
        /// <returns></returns>
        public ProductModel GetProductById(int id)
        {
            return _productService.Get(id).ToModel();
        }

        /// <summary>
        /// 根据分类获取产品列表
        /// </summary>
        /// <param name="category">分类</param>
        /// <returns></returns>
        public IList<ProductModel> GetProductsByCategory(string category)
        {
            var list = _productService.GetByCatagory(category);

            return list.Select(o => o.ToModel()).ToList();
        }
    }
}
