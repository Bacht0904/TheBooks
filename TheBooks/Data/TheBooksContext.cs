using Microsoft.EntityFrameworkCore;
using SellingBooks.Models;
using TheBooks.Models;

namespace TheBooks.Data
{
    public class TheBooksContext:DbContext
    {
        public TheBooksContext(DbContextOptions<TheBooksContext> options) : base(options)
        {
        }
       
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }


    }

}
