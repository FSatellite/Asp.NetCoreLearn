using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RozarPagesMovie.Data;
using RozarPagesMovie.Models;

namespace RozarPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RozarPagesMovie.Data.RozarPagesMovieContext _context;

        public IndexModel(RozarPagesMovie.Data.RozarPagesMovieContext context)
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
