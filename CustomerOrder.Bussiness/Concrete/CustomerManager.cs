using CustomerOrder.Bussiness.Abstract;
using CustomerOrder.DataAccess.Concrete;
using CustomerOrder.Entities;
using System.Collections.Generic;

namespace CustomerOrder.Bussiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private CustomerRepository _customerRepository;
        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }

        public Customers UpdateCustomer(Customers address)
        {
            return _customerRepository.UpdateCustomer(address);
        }
    }
}
