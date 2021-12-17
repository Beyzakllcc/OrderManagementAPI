using CustomerOrder.Entities;
using System.Collections.Generic;

namespace CustomerOrder.DataAccess.Abstract
{
    public interface ICustomerRepository
    {
        Customers UpdateCustomer(Customers address);
    }
}
