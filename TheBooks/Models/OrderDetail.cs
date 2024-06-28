using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SellingBooks.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        [DisplayName("Giá")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal Price { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
        public Order Orders { get; set; }
        public Product Products { get; set; }
    }
}
