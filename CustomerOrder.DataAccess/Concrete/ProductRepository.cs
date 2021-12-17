using CustomerOrder.DataAccess.Abstract;
using CustomerOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerOrder.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public List<Products> GetProduct()
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                return customerDbContext.Products.ToList();
            }
        }

        public Products UpdateProduct(Products quantity)
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                customerDbContext.Products.Update(quantity);
                return quantity;
            }
        }
    }
}
