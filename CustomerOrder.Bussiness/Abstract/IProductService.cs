using CustomerOrder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Bussiness.Abstract
{
    public interface IProductService
    {
        Products UpdateProduct(Products quantity);
        List<Products> GetProducts();
    }
}
