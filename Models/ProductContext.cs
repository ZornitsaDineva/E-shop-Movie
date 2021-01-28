using Microsoft.EntityFrameworkCore;

namespace E_shop_Movie.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("E_shop_MovieContext")
        {
        }

        public DbSet<DbLoggerCategory> Categories { get; set; }
        public DbSet<ProductContext> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
