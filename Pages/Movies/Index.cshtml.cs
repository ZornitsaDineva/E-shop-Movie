using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_shop_Movie.Data;
using E_shop_Movie.Models;

namespace E_shop_Movie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly E_shop_Movie.Data.E_shop_MovieContext _context;

        public IndexModel(E_shop_Movie.Data.E_shop_MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
