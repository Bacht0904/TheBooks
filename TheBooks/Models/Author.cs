using SellingBooks.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [DisplayName("Tác giả")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
