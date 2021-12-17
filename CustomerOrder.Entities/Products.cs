using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerOrder.Entities
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [StringLength(50)]
        public string Barcode { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public int Quantity { get; set; }      
        public int Price { get; set; }
        public List<CustomerOrders> CustomerOrders { get; set; }

    }
}
