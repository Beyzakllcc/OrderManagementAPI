using CustomerOrder.DataAccess.Abstract;
using CustomerOrder.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CustomerOrder.DataAccess.Concrete
{
    public class CustomerOrderRepository :ICustomerOrderRepository
    {
        public CustomerOrders CreateOrder(CustomerOrders order)
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                customerDbContext.Orders.Add(order);
                customerDbContext.SaveChanges();
                return order;
            }
        }

        public void DeleteOrder(int id)
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                var deletedOrder = GetOrderById(id);
                customerDbContext.Orders.Remove(deletedOrder);
                customerDbContext.SaveChanges();
            }
        }

        public List<CustomerOrders> GetAllOrders()
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                return customerDbContext.Orders.ToList();
            }
        }

        public CustomerOrders GetOrderById(int id)
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                return customerDbContext.Orders.Find(id);
            }
        }

        public CustomerOrders UpdateOrder(CustomerOrders order)
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                customerDbContext.Orders.Update(order);
                return order;
            }
        }
    }
}
