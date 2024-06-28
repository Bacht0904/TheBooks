using SellingBooks.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TheBooks.Models
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        [DisplayName("Thông tin Giảm giá")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string name { get; set; }

        [DisplayName("Phần trăm giảm")]
        public int DisPercent { get; set; }

        [DisplayName("Ngày bắt đầu")]
        public DateTime StartDate { get; set; }

        [DisplayName("Ngày kết thúc")]
        public DateTime EndDate { get; set; }

        [DisplayName("Còn hiệu lực")]
        public bool Status { get; set; }

        //Collection navigation property cho khóa ngoại từ Product
        public ICollection<Product> Products { get; set; }
    }
}
