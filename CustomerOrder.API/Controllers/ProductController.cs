using CustomerOrder.Bussiness.Abstract;
using CustomerOrder.Bussiness.Concrete;
using CustomerOrder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController()
        {
            _productService = new ProductManager();
        }
        [HttpGet]
        public List<Products> Get()
        {
            return _productService.GetProducts();
        }

        [HttpPut]
        public Products Put([FromBody] Products quantity)
        {
            return _productService.UpdateProduct(quantity);
        }
    }
}
