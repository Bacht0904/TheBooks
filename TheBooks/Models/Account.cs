using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheBooks.Models;
using TheBooks.Enum;

namespace SellingBooks.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} từ 6-20 kí tự")]
        public string Username { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} từ 6-50 kí tự")]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0} từ 6-50 kí tự")]
        [Compare("Password", ErrorMessage = "Mật khẩu không trùng khớp")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "{0} không hợp lệ")]
        public string Email { get; set; }

        [DisplayName("SĐT")]
        [RegularExpression(@"0\d{9}", ErrorMessage = "SĐT không hợp lệ")]
        public string Phone { get; set; }

        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [DisplayName("Họ tên")]
        public string FullName { get; set; }

        [DisplayName("Phân quyền")]
        [Column(TypeName = "tinyint")]
        public Role RoleId { get; set; } = Role.User;

        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }

        [DisplayName("Trạng thái")]
        [Column(TypeName = "tinyint")]
        public AccountStatus Status { get; set; } = AccountStatus.Block;

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
