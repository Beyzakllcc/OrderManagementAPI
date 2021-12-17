using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerOrder.Entities
{
    public class CustomerOrders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerOrderId { get; set; }
        public Customers Customer { get; set; }
        public int CustId { get; set; }
        public Products Product { get; set; }
        public int ProId { get; set; }
    }
}
