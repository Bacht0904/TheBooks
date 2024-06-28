using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SellingBooks.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [DisplayName("Khách hàng")]
        public int AccountId { get; set; }

        [DisplayName("Khách hàng")]
        public Account Account { get; set; }

        [DisplayName("Sản phẩm")]
        public int ProductId { get; set; }
 
        [DisplayName("Sản phẩm")]
        public Product Product { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
