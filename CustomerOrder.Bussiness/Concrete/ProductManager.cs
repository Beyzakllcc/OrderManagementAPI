using CustomerOrder.Bussiness.Abstract;
using CustomerOrder.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using CustomerOrder.DataAccess.Abstract;
using CustomerOrder.DataAccess.Concrete;

namespace CustomerOrder.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private ProductRepository _productRepository;
        public ProductManager()
        {
            _productRepository = new ProductRepository();
        }
        public List<Products> GetProducts()
        {
            return _productRepository.GetProduct();
        }

        public Products UpdateProduct(Products quantity)
        {
            return _productRepository.UpdateProduct(quantity);
        }
    }
}
