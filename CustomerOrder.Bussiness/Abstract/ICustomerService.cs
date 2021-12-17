using CustomerOrder.Entities;
using System.Collections.Generic;

namespace CustomerOrder.Bussiness.Abstract
{
    public interface ICustomerService
    {
        Customers UpdateCustomer(Customers address);
    }
}
