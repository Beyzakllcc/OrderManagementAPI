using CustomerOrder.Bussiness.Abstract;
using CustomerOrder.Bussiness.Concrete;
using CustomerOrder.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        private ICustomerOrderService _orderService;
        public CustomerOrderController()
        {
            _orderService = new CustomerOrderManager();
        }
        [HttpGet]
        public List<CustomerOrders> Get()
        {
            return _orderService.GetAllOrders();
        }

        [HttpGet("{id}")]
        public CustomerOrders Get(int id)
        {
            return _orderService.GetOrderById(id);
        }
        [HttpPost]
        public CustomerOrders Post([FromBody] CustomerOrders order)
        {
            return _orderService.CreateOrder(order);
        }
        [HttpPut]
        public CustomerOrders Put([FromBody] CustomerOrders order)
        {
            return _orderService.UpdateOrder(order);
        }

        [HttpPut]
        public void Delete(int id)
        {
            _orderService.DeleteOrder(id);
        }
    }
}
