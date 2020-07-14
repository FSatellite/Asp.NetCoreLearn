using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RozarPagesMovie.Models;

namespace RozarPagesMovie.Data
{
    public class RozarPagesMovieContext : DbContext
    {
        public RozarPagesMovieContext (DbContextOptions<RozarPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RozarPagesMovie.Models.Movie> Movie { get; set; }
    }
}
