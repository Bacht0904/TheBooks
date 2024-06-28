using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SellingBooks.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [DisplayName("Doanh mục")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        [DisplayName("Còn hiệu lực")]

        // Collection navigation property cho khóa ngoại từ Product
        public ICollection<Product> Products { get; set; }
    }
}
