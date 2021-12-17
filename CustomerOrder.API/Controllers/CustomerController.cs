using CustomerOrder.Bussiness.Abstract;
using CustomerOrder.Bussiness.Concrete;
using CustomerOrder.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerManager();
        }

        [HttpPut]
        public Customers Put([FromBody] Customers address)
        {
            return _customerService.UpdateCustomer(address);
        }
    }
}
