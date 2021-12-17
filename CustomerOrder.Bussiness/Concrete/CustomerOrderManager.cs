using CustomerOrder.Bussiness.Abstract;
using CustomerOrder.DataAccess.Concrete;
using CustomerOrder.Entities;
using System.Collections.Generic;

namespace CustomerOrder.Bussiness.Concrete
{
    public class CustomerOrderManager : ICustomerOrderService
    {
        private CustomerOrderRepository _orderRepository;
        public CustomerOrderManager()
        {
            _orderRepository = new CustomerOrderRepository();
        }
        public CustomerOrders CreateOrder(CustomerOrders order)
        {
            return _orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }

        public List<CustomerOrders> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public CustomerOrders GetOrderById(int id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public CustomerOrders UpdateOrder(CustomerOrders address)
        {
            return _orderRepository.UpdateOrder(address);
        }
    }
}
