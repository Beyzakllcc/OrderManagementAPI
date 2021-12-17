using CustomerOrder.DataAccess.Abstract;
using CustomerOrder.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CustomerOrder.DataAccess.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
  
        public Customers UpdateCustomer(Customers address)
        {
            using (var customerDbContext = new CustomerOrderDbContext())
            {
                customerDbContext.Customers.Update(address);
                return address;
            }
        }
    }
}
