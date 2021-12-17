using CustomerOrder.Entities;
using System.Collections.Generic;

namespace CustomerOrder.DataAccess.Abstract
{
    public interface ICustomerOrderRepository
    {
        List<CustomerOrders> GetAllOrders();
        CustomerOrders GetOrderById(int id);
        CustomerOrders CreateOrder(CustomerOrders order);
        CustomerOrders UpdateOrder(CustomerOrders order);
        void DeleteOrder(int id);
    }
}
