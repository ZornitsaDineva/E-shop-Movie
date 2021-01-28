using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_shop_Movie.Models;

namespace E_shop_Movie.Data
{
    public class E_shop_MovieContext : DbContext
    {
        public E_shop_MovieContext (DbContextOptions<E_shop_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
