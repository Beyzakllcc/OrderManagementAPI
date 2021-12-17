using CustomerOrder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.DataAccess.Abstract
{
    public interface IProductRepository
    {
        Products UpdateProduct(Products quantity);
        List<Products> GetProduct();
    }
}
