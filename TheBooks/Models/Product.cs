using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TheBooks.Models;

namespace SellingBooks.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string SKU { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Giá (VNĐ)")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal Price { get; set; }

        [DisplayName("Tồn kho")]
        public int Quantity { get; set; }

        [DisplayName("Nhà xuất bản")]
        public string Publisher { get; set; }

        [DisplayName("Ngày Xuất bản")]
        public DateTime PublishDate { get; set; }

        [DisplayName("Tác giả")]
        public int AuthorId { get; set; }

        [DisplayName("Tác giả")]
        public Author Author { get; set; }

        [DisplayName("Giảm giá")]
        public int DiscountId { get; set; }

        [DisplayName("Giảm giá")]
        public Discount Discounts { get; set; }

        [DisplayName("Doanh mục")]
        public int CategoryId { get; set; }

        [DisplayName("Doanh mục")]
        public Category Category { get; set; }

        [DisplayName("Ảnh minh họa")]
        public string Image { get; set; }

        [DisplayName("Còn hiệu lực")]
        public bool Status { get; set; }

        public ICollection<Cart> Carts { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
