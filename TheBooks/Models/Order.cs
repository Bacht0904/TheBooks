using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheBooks.Enum;

namespace SellingBooks.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [DisplayName("Mã hóa đơn")]
        public string Code { get; set; }

        [DisplayName("Khách hàng")]
        public int AccountId { get; set; }

        [DisplayName("Khách hàng")]
        public Account Account { get; set; }

        [DisplayName("Ngày lập")]
        public DateTime CreateDate { get; set; }

        [DisplayName("Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }

        [DisplayName("SĐT giao hàng")]
        public string ShippingPhone { get; set; }

        [DisplayName("Tổng tiền")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public int Total { get; set; }

        [DisplayName("Còn hiệu lực")]
        public bool Status { get; set; }

        [Column(TypeName = "tinyint")]
        public Payment Payment { get; set; } = Payment.COD;
        public ICollection<Product> Products { get; set; }
    }
}
